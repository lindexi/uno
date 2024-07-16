#if UNO_HAS_MANAGED_POINTERS
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Windows.Devices.Input;
using Uno;
using Windows.Foundation;
using Microsoft.UI.Xaml.Media;
using Windows.UI.Core;

using PointerEventArgs = Windows.UI.Core.PointerEventArgs;

#if HAS_UNO_WINUI
using Microsoft.UI.Input;
using PointerDeviceType = Microsoft.UI.Input.PointerDeviceType;
#else
using Windows.UI.Input;
using PointerDeviceType = Windows.Devices.Input.PointerDeviceType;
#endif

namespace Microsoft.UI.Xaml.Input
{
	partial class PointerRoutedEventArgs
	{
		private readonly PointerEventArgs _pointerEventArgs;
		private readonly PointerPoint _currentPoint;

		internal PointerEventArgs CoreArgs => _pointerEventArgs;

		internal PointerRoutedEventArgs(
			PointerEventArgs pointerEventArgs,
			UIElement source) : this()
		{
			_pointerEventArgs = pointerEventArgs;

#if HAS_UNO_WINUI
			_currentPoint = new PointerPoint(_pointerEventArgs.CurrentPoint);
#else
			_currentPoint = _pointerEventArgs.CurrentPoint;
#endif

			FrameId = pointerEventArgs.CurrentPoint.FrameId;
			Pointer = GetPointer(pointerEventArgs);
			KeyModifiers = pointerEventArgs.KeyModifiers;
			OriginalSource = source;
		}

		public IList<PointerPoint> GetIntermediatePoints(UIElement relativeTo)
		{
#if HAS_UNO_WINUI
			var intermediatePoints = _pointerEventArgs.GetIntermediatePoints();
			if (relativeTo is null)
			{
				return intermediatePoints.Select(p => new PointerPoint(p)).ToList();
			}
			else
			{
				var generalTransform = relativeTo.TransformToVisual(null).Inverse;
				var result = new List<PointerPoint>(intermediatePoints.Count);
				foreach (var intermediatePoint in intermediatePoints)
				{
					var point = new PointerPoint(intermediatePoint); // 这里将会浪费一个对象，好像这样的小对象对 GC 压力很小。在使用 At 方法时将会执行转换，创建新的对象，如此可以让代码简单
					var absolutePosition = point.Position;
					var relativePosition = generalTransform.TransformPoint(absolutePosition);
					result.Add(point.At(relativePosition));
				}
				return result;
			}
#else
			return new List<PointerPoint>(1) { GetCurrentPoint(relativeTo) };
#endif
		}

		public PointerPoint GetCurrentPoint(UIElement relativeTo)
		{
			if (relativeTo is null)
			{
				return _currentPoint;
			}
			else
			{
				var absolutePosition = _pointerEventArgs.CurrentPoint.Position;
				var relativePosition = relativeTo.TransformToVisual(null).Inverse.TransformPoint(absolutePosition);

				return _currentPoint.At(relativePosition);
			}
		}

		private Pointer GetPointer(PointerEventArgs args)
			=> new Pointer(
				args.CurrentPoint.PointerId,
				(PointerDeviceType)args.CurrentPoint.PointerDevice.PointerDeviceType,
				isInContact: args.CurrentPoint.IsInContact,
				isInRange: args.CurrentPoint.Properties.IsInRange);
	}
}
#endif
