#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Media
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class TileBrush : global::Microsoft.UI.Xaml.Media.Brush
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Xaml.Media.Stretch Stretch
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Media.Stretch)this.GetValue(StretchProperty);
			}
			set
			{
				this.SetValue(StretchProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Xaml.Media.AlignmentY AlignmentY
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Media.AlignmentY)this.GetValue(AlignmentYProperty);
			}
			set
			{
				this.SetValue(AlignmentYProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Xaml.Media.AlignmentX AlignmentX
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Media.AlignmentX)this.GetValue(AlignmentXProperty);
			}
			set
			{
				this.SetValue(AlignmentXProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.UI.Xaml.DependencyProperty AlignmentXProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(AlignmentX), typeof(global::Microsoft.UI.Xaml.Media.AlignmentX), 
			typeof(global::Microsoft.UI.Xaml.Media.TileBrush), 
			new Microsoft.UI.Xaml.FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Media.AlignmentX)));
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.UI.Xaml.DependencyProperty AlignmentYProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(AlignmentY), typeof(global::Microsoft.UI.Xaml.Media.AlignmentY), 
			typeof(global::Microsoft.UI.Xaml.Media.TileBrush), 
			new Microsoft.UI.Xaml.FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Media.AlignmentY)));
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.UI.Xaml.DependencyProperty StretchProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(Stretch), typeof(global::Microsoft.UI.Xaml.Media.Stretch), 
			typeof(global::Microsoft.UI.Xaml.Media.TileBrush), 
			new Microsoft.UI.Xaml.FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Media.Stretch)));
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		protected TileBrush() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Media.TileBrush", "TileBrush.TileBrush()");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Media.TileBrush.TileBrush()
		// Forced skipping of method Microsoft.UI.Xaml.Media.TileBrush.AlignmentX.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.TileBrush.AlignmentX.set
		// Forced skipping of method Microsoft.UI.Xaml.Media.TileBrush.AlignmentY.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.TileBrush.AlignmentY.set
		// Forced skipping of method Microsoft.UI.Xaml.Media.TileBrush.Stretch.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.TileBrush.Stretch.set
		// Forced skipping of method Microsoft.UI.Xaml.Media.TileBrush.AlignmentXProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.TileBrush.AlignmentYProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.TileBrush.StretchProperty.get
	}
}