#nullable enable
using System.Collections.Generic;
using Windows.System;
using Windows.UI.Input;

namespace Windows.UI.Core
{
	public partial class PointerEventArgs : ICoreWindowEventArgs
	{
		internal PointerEventArgs(PointerPoint currentPoint, VirtualKeyModifiers keyModifiers) : this(currentPoint, keyModifiers, null)
		{
		}

		internal PointerEventArgs(PointerPoint currentPoint, VirtualKeyModifiers keyModifiers,
			IList<PointerPoint>? intermediatePoints)
		{
			CurrentPoint = currentPoint;
			KeyModifiers = keyModifiers;
			_intermediatePoints = intermediatePoints;
		}

		public bool Handled { get; set; }

		public PointerPoint CurrentPoint { get; }

		public VirtualKeyModifiers KeyModifiers { get; }

		public IList<PointerPoint> GetIntermediatePoints() =>
			_intermediatePoints ??= new List<PointerPoint> { CurrentPoint };

		private IList<PointerPoint>? _intermediatePoints;

		/// <inheritdoc />
		public override string ToString()
			=> $"{CurrentPoint} | modifiers: {KeyModifiers}";
	}
}
