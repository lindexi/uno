using Windows.Foundation;
using Microsoft.UI.Input;
using Microsoft.UI.Xaml.Controls;
using Uno.UI.Hosting;
using Windows.Devices.Input;
using PointerDeviceType = Windows.Devices.Input.PointerDeviceType;
using PointerEventArgs = Windows.UI.Core.PointerEventArgs;
using static Microsoft.UI.Xaml.Controls.Primitives.LoopingSelectorItem;

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

		// Time is given in milliseconds since system boot
		// This matches the format of WinUI. See also: https://github.com/unoplatform/uno/issues/14535
		var position = new Point(x / scale, y / scale);
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
}
