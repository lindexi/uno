using System;
using Windows.Foundation;
using Microsoft.UI.Xaml.Controls;
using Uno.UI.Hosting;
using Windows.Devices.Input;
using PointerDeviceType = Windows.Devices.Input.PointerDeviceType;
using PointerEventArgs = Windows.UI.Core.PointerEventArgs;
using static Microsoft.UI.Xaml.Controls.Primitives.LoopingSelectorItem;
using System.Collections.Generic;
using System.Globalization;
using Windows.UI.Input;

namespace Uno.WinUI.Runtime.Skia.X11;

internal partial class X11PointerInputSource
{
	public unsafe void ProcessXIEnterEvent(XIEnterLeaveEvent* enterLeaveEvent)
	{
		var args = ToPointerEventArgs(enterLeaveEvent);
		X11XamlRootHost.QueueAction(_host, () => RaisePointerEntered(args));
	}

	public unsafe void ProcessXILeaveEvent(XIEnterLeaveEvent* enterLeaveEvent)
	{
		// 上层判断了
		// enterLeaveEvent->detail is
		// // 如果来源于上层，则忽略
		// XiEnterLeaveDetail.XINotifyAncestor
		var args = ToPointerEventArgs(enterLeaveEvent);
		X11XamlRootHost.QueueAction(_host, () => RaisePointerExited(args));
	}

	private unsafe PointerEventArgs ToPointerEventArgs(XIEnterLeaveEvent* enterLeaveEvent)
	{
		var timestamp = (ulong)enterLeaveEvent->time.ToInt64();
		var state = (XModifierMask)enterLeaveEvent->mods.Effective;

		var scale = ((IXamlRootHost)_host).RootElement?.XamlRoot is { } root
			? root.RasterizationScale
			: 1;
		var x = enterLeaveEvent->event_x;
		var y = enterLeaveEvent->event_y;
		var position = new Point(x / scale, y / scale);

		var modifiers = X11XamlRootHost.XModifierMaskToVirtualKeyModifiers(state);

		var properties = new PointerPointProperties
		{
			IsLeftButtonPressed = true,
			IsMiddleButtonPressed = false,
			IsRightButtonPressed = false
		};

		bool isMouse = true;

		var point = new PointerPoint(
			frameId: (uint)timestamp, // UNO TODO: How should set the frame, timestamp may overflow.
			timestamp: (uint)timestamp,
			PointerDevice.For(isMouse ? PointerDeviceType.Mouse : PointerDeviceType.Touch),
			(uint)0,
			position,
			position,
			false,
			properties
		);

		var pointerEventArgs = new PointerEventArgs(point, modifiers);
		return pointerEventArgs;
	}

	public unsafe void DispatchMessage(XIDeviceEvent* xiDeviceEvent, X11Window x11Window)
	{
		var state = (XModifierMask)xiDeviceEvent->mods.Effective;

		var (shouldIgnore, point) = ParsePointerPoint(xiDeviceEvent);
		if (shouldIgnore)
		{
			return;
		}

		List<PointerPoint>? intermediatePoints = null;
		if (IsMove(xiDeviceEvent->evtype))
		{
			// 在移动过程中，尝试读取历史点
			intermediatePoints = TryReadIntermediatePoints(point, x11Window);

			// 如果能读取到历史点，那当前点将需要更换为最后一个点
			if (intermediatePoints is { Count: > 1 })
			{
				point = intermediatePoints[^1];
			}
		}

		var modifiers = X11XamlRootHost.XModifierMaskToVirtualKeyModifiers(state);

		var pointerEventArgs = new PointerEventArgs(point, modifiers, intermediatePoints);

		var xiEvent = xiDeviceEvent;
		if (xiEvent->evtype is XiEventType.XI_TouchBegin or XiEventType.XI_ButtonPress)
		{
			//OnDown(in deviceInputArgs);
			X11XamlRootHost.RunAsync(_host, () => RaisePointerPressed(pointerEventArgs))?.GetResults();
		}
		else if (xiEvent->evtype is XiEventType.XI_TouchUpdate or XiEventType.XI_Motion)
		{
			//Console.WriteLine($"Move={id} {stylusPoint.Point.X},{stylusPoint.Point.Y}");
			//OnMove(in deviceInputArgs);
			X11XamlRootHost.RunAsync(_host, () => RaisePointerMoved(pointerEventArgs))?.GetResults();
		}
		else if (xiEvent->evtype is XiEventType.XI_TouchEnd or XiEventType.XI_ButtonRelease)
		{
			//OnUp(in deviceInputArgs);
			X11XamlRootHost.RunAsync(_host, () => RaisePointerReleased(pointerEventArgs))?.GetResults();
		}
	}

	private bool IsMove(XiEventType eventType)
	{
		if (eventType is
		    // 只有移动系的，才可以合并，其他的不能合并
		    //XiEventType.XI_ButtonPress
		    //or XiEventType.XI_ButtonRelease
		    XiEventType.XI_Motion
		    //or XiEventType.XI_TouchBegin
		    or XiEventType.XI_TouchUpdate
		    //or XiEventType.XI_TouchEnd
		   )
		{
			return true;
		}

		return false;
	}

	private unsafe (bool ShouldIgnore, PointerPoint PointerPoint) ParsePointerPoint(XIDeviceEvent* xiDeviceEvent)
	{
		bool isMouse = false;

		if (xiDeviceEvent->evtype is
		    XiEventType.XI_ButtonPress
		    or XiEventType.XI_ButtonRelease
		    or XiEventType.XI_Motion)
		{
			if ((xiDeviceEvent->flags & XiDeviceEventFlags.XIPointfocuserEmulated) ==
			    XiDeviceEventFlags.XIPointfocuserEmulated)
			{
				// 多指触摸下是模拟的，则忽略
				//Console.WriteLine("多指触摸下是模拟的");
				return (ShouldIgnore: true, PointerPoint: default!);
			}

			isMouse = true;
		}

		var timestamp = (ulong)xiDeviceEvent->time.ToInt64();

		var id = xiDeviceEvent->detail;

		//Console.WriteLine($"Dispatcher Id={id} X11DeviceInputManager != null={X11DeviceInputManager != null}");

		if (isMouse)
		{
			// 由于在 XI_ButtonPress 时的 id 是 1 而 XI_Motion 是 0 导致无法画出线
			id = 0;
		}

		var properties = new PointerPointProperties
		{
			IsLeftButtonPressed = true,
			IsMiddleButtonPressed = false,
			IsRightButtonPressed = false
		};

		var scale = ((IXamlRootHost)_host).RootElement?.XamlRoot is { } root
			? root.RasterizationScale
			: 1;

		var x = xiDeviceEvent->event_x;
		var y = xiDeviceEvent->event_y;
		var position = new Point(x / scale, y / scale);

		if (X11DeviceInputManager is {} x11DeviceInputManager)
		{
			var valuatorDictionary = _cacheValuatorDictionary;
			valuatorDictionary.Clear();

			var values = xiDeviceEvent->valuators.Values;
			for (var c = 0; c < xiDeviceEvent->valuators.MaskLen * 8; c++)
			{
				if (XLib.XIMaskIsSet(xiDeviceEvent->valuators.Mask, c))
				{
					valuatorDictionary[c] = *values;
					values++;
				}
			}

			float? pressure = null;

			//double? physicalWidth = null;
			//double? physicalHeight = null;

			double? pixelWidth = null;
			double? pixelHeight = null;

			var touchMajorValuatorClassInfo = x11DeviceInputManager.TouchMajorValuatorClassInfo;
			var touchMinorValuatorClassInfo = x11DeviceInputManager.TouchMinorValuatorClassInfo;
			var pressureValuatorClassInfo = x11DeviceInputManager.PressureValuatorClassInfo;

			foreach (var (key, value) in valuatorDictionary)
			{
				if (key == touchMajorValuatorClassInfo?.Number)
				{
					//physicalWidth = value / touchMajorValuatorClassInfo.Value.Resolution *
					//                _infoManager.ScreenPhysicalWidthCentimetre;
					pixelWidth = (value - touchMajorValuatorClassInfo.Value.Min) /
					             (touchMajorValuatorClassInfo.Value.Max -
					              touchMajorValuatorClassInfo.Value.Min) *
					             x11DeviceInputManager.XDisplayWidth;
				}
				else if (key == touchMinorValuatorClassInfo?.Number)
				{
					//physicalHeight = value / touchMinorValuatorClassInfo.Value.Resolution *
					//                 _infoManager.ScreenPhysicalHeightCentimetre;

					pixelHeight = (value - touchMinorValuatorClassInfo.Value.Min) /
					              (touchMinorValuatorClassInfo.Value.Max -
					               touchMinorValuatorClassInfo.Value.Min) *
					              x11DeviceInputManager.XDisplayHeight;
				}
				else if (key == pressureValuatorClassInfo?.Number)
				{
					var xiValuatorClassInfo = pressureValuatorClassInfo.Value;

					pressure = (float)((value - xiValuatorClassInfo.Min) / (xiValuatorClassInfo.Max - xiValuatorClassInfo.Min));
				}
			}

			if (pressure is not null)
			{
				properties.Pressure = pressure.Value;
			}

			if (pixelWidth != null || pixelHeight != null)
			{
				if (pixelWidth == null)
				{
					// 基本上不会进入此分支
					pixelWidth = pixelHeight;
				}

				if (pixelHeight == null)
				{
					// 这是兼容实现的代码
					pixelHeight = pixelWidth;
				}

				// 也许需要缩放一下？
				properties.ContactRect = new Rect(position, new Size(pixelWidth!.Value, pixelHeight!.Value));
			}
		}

		// Time is given in milliseconds since system boot
		// This matches the format of WinUI. See also: https://github.com/unoplatform/uno/issues/14535
		var point = new PointerPoint(
			frameId: (uint)timestamp, // UNO TODO: How should set the frame, timestamp may overflow.
			timestamp: (uint)timestamp,
			PointerDevice.For(isMouse ? PointerDeviceType.Mouse : PointerDeviceType.Touch),
			(uint)id,
			position,
			position,
			false,
			properties
		);
		return (ShouldIgnore: false, PointerPoint: point);
	}

	private unsafe List<PointerPoint>? TryReadIntermediatePoints(PointerPoint currentPoint, X11Window x11Window)
	{
		var currentId = (int) currentPoint.PointerId;

		List<PointerPoint>? intermediatePoints = null;

		var count = XLib.XEventsQueued(x11Window.Display, 0 /*QueuedAlready*/);
		for (int i = 0; i < count; i++)
		{
			XLib.XPeekEvent(x11Window.Display, out var @event);
			if (@event.type == XEventName.GenericEvent)
			{
				var data = &@event.GenericEventCookie;
				XLib.XGetEventData(x11Window.Display, data);
				try
				{
					var xiEvent = (XIEvent*)@event.GenericEventCookie.data;
					if (IsMove(xiEvent->evtype))
					{
						var xiDeviceEvent = (XIDeviceEvent*)xiEvent;
						var isSame = xiDeviceEvent->detail == currentId;
						if (!isSame)
						{
							// 收到别的触摸点，出让，调度其他的事件
							break;
						}

						var (shouldIgnore, point) = ParsePointerPoint(xiDeviceEvent);
						if (!shouldIgnore)
						{
							if (intermediatePoints is null)
							{
								intermediatePoints = new List<PointerPoint>(2)
								{
									currentPoint
								};
							}
							intermediatePoints.Add(point);
						}

						// 读走数据，用于下次读取到新的数据
						XLib.XNextEvent(x11Window.Display, out _);

						// 使用 continue 重新进入循环
						continue;
					}
				}
				finally
				{
					XLib.XFreeEventData(x11Window.Display, data);
				}
			}

			// 不满足条件的，不能处理，返回给到外面，这里直接返回即可
			// 所有符合条件都使用 continue 继续循环
			return intermediatePoints;
		}

		return intermediatePoints;
	}

	public X11DeviceInputManager? X11DeviceInputManager { get; set; }

	private readonly Dictionary<int, double> _cacheValuatorDictionary = new Dictionary<int, double>();
}
