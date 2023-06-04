﻿#nullable enable

using Uno.UI.Xaml.Hosting;
using WpfCanvas = System.Windows.Controls.Canvas;

namespace Uno.UI.Runtime.Skia.Wpf.Hosting;

internal interface IWpfXamlRootHost : IXamlRootHost
{
	WpfCanvas? NativeOverlayLayer { get; }

	bool IgnorePixelScaling { get; }
}