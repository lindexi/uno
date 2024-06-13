using System;
using System.Collections.Generic;

namespace Uno.WinUI.Runtime.Skia.X11;

unsafe class X11DeviceInputManager
{
	public X11DeviceInputManager(IntPtr display)
	{
		Display = display;

		var devices = (XIDeviceInfo*)XLib.XIQueryDevice(Display,
			(int)XiPredefinedDeviceId.XIAllMasterDevices, out int num);

		XIDeviceInfo? pointerDevice = default;

		for (var c = 0; c < num; c++)
		{
			//StaticDebugLogger.WriteLine($"XIDeviceInfo [{c}] {devices[c].Deviceid} {devices[c].Use}");

			if (devices[c].Use == XiDeviceType.XIMasterPointer)
			{
				pointerDevice = devices[c];
				break;
			}
		}

		PointerDevice = pointerDevice;

		// ABS_MT_TOUCH_MAJOR ABS_MT_TOUCH_MINOR
		// https://www.kernel.org/doc/html/latest/input/multi-touch-protocol.html
		var touchMajorAtom = XLib.XInternAtom(Display, "Abs MT Touch Major", false);
		var touchMinorAtom = XLib.XInternAtom(Display, "Abs MT Touch Minor", false);
		IntPtr pressureAtom = XLib.XInternAtom(Display, "Abs MT Pressure", false);

		//StaticDebugLogger.WriteLine(
		//	$"ABS_MT_TOUCH_MAJOR={touchMajorAtom} Name={XLib.GetAtomName(Display, touchMajorAtom)} ABS_MT_TOUCH_MINOR={touchMinorAtom} Name={XLib.GetAtomName(Display, touchMinorAtom)} Abs_MT_Pressure={pressureAtom} Name={XLib.GetAtomName(Display, pressureAtom)}");

		if (pointerDevice != null)
		{
			//StaticDebugLogger.WriteLine($"pointerDevice.Value.NumClasses={pointerDevice.Value.NumClasses}");

			for (int i = 0; i < pointerDevice.Value.NumClasses; i++)
			{
				var xiAnyClassInfo = pointerDevice.Value.Classes[i];
				if (xiAnyClassInfo->Type == XiDeviceClass.XIValuatorClass)
				{
					_valuators.Add(*((XIValuatorClassInfo**)pointerDevice.Value.Classes)[i]);
				}
				else if (xiAnyClassInfo->Type == XiDeviceClass.XIScrollClass)
				{
					_scrollers.Add(*((XIScrollClassInfo**)pointerDevice.Value.Classes)[i]);
				}
			}

			foreach (var xiValuatorClassInfo in _valuators)
			{
				//var label = xiValuatorClassInfo.Label;
				//// 不能通过 Marshal.PtrToStringAnsi 读取 Label 的值 读取不到
				////Marshal.PtrToStringAnsi(xiValuatorClassInfo.Label);
				//Console.WriteLine($"[Valuator] [{GetAtomName(Display, label)}] Label={label} Type={xiValuatorClassInfo.Type} Sourceid={xiValuatorClassInfo.Sourceid} Number={xiValuatorClassInfo.Number} Min={xiValuatorClassInfo.Min} Max={xiValuatorClassInfo.Max} Value={xiValuatorClassInfo.Value} Resolution={xiValuatorClassInfo.Resolution} Mode={xiValuatorClassInfo.Mode}");
				if (xiValuatorClassInfo.Label == touchMajorAtom)
				{
					TouchMajorValuatorClassInfo = xiValuatorClassInfo;
				}
				else if (xiValuatorClassInfo.Label == touchMinorAtom)
				{
					TouchMinorValuatorClassInfo = xiValuatorClassInfo;
				}
				else if (xiValuatorClassInfo.Label == pressureAtom)
				{
					PressureValuatorClassInfo = xiValuatorClassInfo;
				}
			}
		}
	}

	public IntPtr Display { get; }

	public XIDeviceInfo? PointerDevice { get; }

	public XIValuatorClassInfo? TouchMajorValuatorClassInfo { get; }

	public XIValuatorClassInfo? TouchMinorValuatorClassInfo { get; }

	public XIValuatorClassInfo? PressureValuatorClassInfo { get; }

	public IReadOnlyList<XIValuatorClassInfo> Valuators => _valuators;
	public IReadOnlyList<XIScrollClassInfo> Scrollers => _scrollers;

	private readonly List<XIValuatorClassInfo> _valuators = new List<XIValuatorClassInfo>();
	private readonly List<XIScrollClassInfo> _scrollers = new List<XIScrollClassInfo>();


	///// <summary>
	///// 调度消息处理
	///// </summary>
	///// <param name="xiDeviceEvent"></param>
	///// <returns>返回 false 代表消息不能被处理</returns>
	//public void DispatchMessage(XIDeviceEvent* xiDeviceEvent)
	//{
	//	var (shouldIgnore, deviceInputArgs) = ParseDeviceInputArgs(xiDeviceEvent);
	//	if (shouldIgnore)
	//	{
	//		// 比如这是模拟的鼠标消息
	//		return;
	//	}

	//	var xiEvent = xiDeviceEvent;
	//	if (xiEvent->evtype is XiEventType.XI_TouchBegin or XiEventType.XI_ButtonPress)
	//	{
	//		OnDown(in deviceInputArgs);
	//	}
	//	else if (xiEvent->evtype is XiEventType.XI_TouchUpdate or XiEventType.XI_Motion)
	//	{
	//		//Console.WriteLine($"Move={id} {stylusPoint.Point.X},{stylusPoint.Point.Y}");
	//		OnMove(in deviceInputArgs);
	//	}
	//	else if (xiEvent->evtype is XiEventType.XI_TouchEnd or XiEventType.XI_ButtonRelease)
	//	{
	//		OnUp(in deviceInputArgs);
	//	}
	//}

	//private (bool ShouldIgnore, DeviceInputArgs Args) ParseDeviceInputArgs(XIDeviceEvent* xiDeviceEvent)
	//{
	//	bool isMouse = false;

	//	if (xiDeviceEvent->evtype is
	//		XiEventType.XI_ButtonPress
	//		or XiEventType.XI_ButtonRelease
	//		or XiEventType.XI_Motion)
	//	{
	//		if ((xiDeviceEvent->flags & XiDeviceEventFlags.XIPointerEmulated) ==
	//			XiDeviceEventFlags.XIPointerEmulated)
	//		{
	//			// 多指触摸下是模拟的，则忽略
	//			//Console.WriteLine("多指触摸下是模拟的");
	//			return (ShouldIgnore: true, Args: default);
	//		}

	//		isMouse = true;
	//	}

	//	var timestamp = (ulong)xiDeviceEvent->time.ToInt64();
	//	var state = (XModifierMask)xiDeviceEvent->mods.Effective;

	//	//var valuatorDictionary = _cacheValuatorDictionary;
	//	//valuatorDictionary.Clear();

	//	//var values = xiDeviceEvent->valuators.Values;
	//	//for (var c = 0; c < xiDeviceEvent->valuators.MaskLen * 8; c++)
	//	//{
	//	//	if (XIMaskIsSet(xiDeviceEvent->valuators.Mask, c))
	//	//	{
	//	//		valuatorDictionary[c] = *values;
	//	//		values++;
	//	//	}
	//	//}

	//	float? pressure = null;

	//	double? physicalWidth = null;
	//	double? physicalHeight = null;

	//	double? pixelWidth = null;
	//	double? pixelHeight = null;

	//	var touchMajorValuatorClassInfo = TouchMajorValuatorClassInfo;
	//	var touchMinorValuatorClassInfo = TouchMinorValuatorClassInfo;
	//	var valuators = Valuators;

	//	//foreach (var (key, value) in valuatorDictionary)
	//	//{
	//	//	if (key == touchMajorValuatorClassInfo?.Number)
	//	//	{
	//	//		physicalWidth = value / touchMajorValuatorClassInfo.Value.Resolution *
	//	//						_infoManager.ScreenPhysicalWidthCentimetre;

	//	//		pixelWidth = (value - touchMajorValuatorClassInfo.Value.Min) /
	//	//					 (touchMajorValuatorClassInfo.Value.Max -
	//	//					  touchMajorValuatorClassInfo.Value.Min) *
	//	//					 _infoManager.XDisplayWidth;
	//	//	}
	//	//	else if (key == touchMinorValuatorClassInfo?.Number)
	//	//	{
	//	//		physicalHeight = value / touchMinorValuatorClassInfo.Value.Resolution *
	//	//						 _infoManager.ScreenPhysicalHeightCentimetre;

	//	//		pixelHeight = (value - touchMinorValuatorClassInfo.Value.Min) /
	//	//					  (touchMinorValuatorClassInfo.Value.Max -
	//	//					   touchMinorValuatorClassInfo.Value.Min) *
	//	//					  _infoManager.XDisplayHeight;
	//	//	}
	//	//	else if (key == PressureValuatorClassInfo?.Number)
	//	//	{
	//	//		var xiValuatorClassInfo = PressureValuatorClassInfo.Value;

	//	//		pressure = (float)((value - xiValuatorClassInfo.Min) / (xiValuatorClassInfo.Max - xiValuatorClassInfo.Min));
	//	//	}
	//	//}

	//	var id = xiDeviceEvent->detail;
	//	if (isMouse)
	//	{
	//		// 由于在 XI_ButtonPress 时的 id 是 1 而 XI_Motion 是 0 导致无法画出线
	//		id = 0;
	//	}

	//	var deviceInputPoint = new DeviceInputPoint(new Point(xiDeviceEvent->event_x, xiDeviceEvent->event_y), timestamp)
	//	{
	//		Pressure = pressure,
	//		PhysicalWidth = physicalWidth,
	//		PhysicalHeight = physicalHeight,

	//		PixelWidth = pixelWidth,
	//		PixelHeight = pixelHeight
	//	};

	//	//StaticDebugLogger.WriteLine($"[{xiDeviceEvent->evtype}][{id}] {deviceInputPoint.Position.X:0.00},{deviceInputPoint.Position.Y:0.00} WH:{physicalWidth:0.00},{physicalHeight:0.00} valuator:{valuatorDictionary.Count}");

	//	var deviceInputArgs = new DeviceInputArgs(id, isMouse, deviceInputPoint);
	//	return (false, deviceInputArgs);
	//}

	//private void OnDown(in DeviceInputArgs deviceInputArgs)
	//{
	//	DevicePressed?.Invoke(this, deviceInputArgs);
	//}

	//private void OnMove(in DeviceInputArgs deviceInputArgs)
	//{
	//	DeviceMoved?.Invoke(this, deviceInputArgs);
	//}

	//private void OnUp(in DeviceInputArgs deviceInputArgs)
	//{
	//	DeviceReleased?.Invoke(this, deviceInputArgs);
	//}

	//public event EventHandler<DeviceInputArgs>? DevicePressed;
	//public event EventHandler<DeviceInputArgs>? DeviceMoved;
	//public event EventHandler<DeviceInputArgs>? DeviceReleased;

	//private readonly Dictionary<int, double> _cacheValuatorDictionary = new Dictionary<int, double>();
	//public List<DeviceInputPoint> CurrentCacheDeviceInputPointList { get; } = new List<DeviceInputPoint>();
}
