using System;
using Windows.Foundation;
using Microsoft.UI.Input;
using Microsoft.UI.Xaml.Controls;
using Uno.UI.Hosting;
using Windows.Devices.Input;
using PointerDeviceType = Windows.Devices.Input.PointerDeviceType;
using PointerEventArgs = Windows.UI.Core.PointerEventArgs;
using static Microsoft.UI.Xaml.Controls.Primitives.LoopingSelectorItem;
using System.Collections.Generic;
using System.Globalization;

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

	public unsafe void DispatchMessage(XIDeviceEvent* xiDeviceEvent)
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
				return;
			}

			isMouse = true;
		}

		var timestamp = (ulong)xiDeviceEvent->time.ToInt64();
		var state = (XModifierMask)xiDeviceEvent->mods.Effective;

		var id = xiDeviceEvent->detail;

		Console.WriteLine($"Dispatcher Id={id} X11DeviceInputManager != null={X11DeviceInputManager != null}");

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
		var modifiers = X11XamlRootHost.XModifierMaskToVirtualKeyModifiers(state);

		var pointerEventArgs = new PointerEventArgs(point, modifiers);

		var xiEvent = xiDeviceEvent;
		if (xiEvent->evtype is XiEventType.XI_TouchBegin or XiEventType.XI_ButtonPress)
		{
			//OnDown(in deviceInputArgs);
			X11XamlRootHost.QueueAction(_host, () => RaisePointerPressed(pointerEventArgs));
		}
		else if (xiEvent->evtype is XiEventType.XI_TouchUpdate or XiEventType.XI_Motion)
		{
			//Console.WriteLine($"Move={id} {stylusPoint.Point.X},{stylusPoint.Point.Y}");
			//OnMove(in deviceInputArgs);
			X11XamlRootHost.QueueAction(_host, () => RaisePointerMoved(pointerEventArgs));
		}
		else if (xiEvent->evtype is XiEventType.XI_TouchEnd or XiEventType.XI_ButtonRelease)
		{
			//OnUp(in deviceInputArgs);
			X11XamlRootHost.QueueAction(_host, () => RaisePointerReleased(pointerEventArgs));
		}
	}

	public X11DeviceInputManager? X11DeviceInputManager { get; set; }

	private readonly Dictionary<int, double> _cacheValuatorDictionary = new Dictionary<int, double>();
}
