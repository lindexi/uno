#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Media.Animation
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class ContinuumNavigationTransitionInfo : global::Microsoft.UI.Xaml.Media.Animation.NavigationTransitionInfo
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Xaml.UIElement ExitElement
		{
			get
			{
				return (global::Microsoft.UI.Xaml.UIElement)this.GetValue(ExitElementProperty);
			}
			set
			{
				this.SetValue(ExitElementProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.UI.Xaml.DependencyProperty ExitElementContainerProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.RegisterAttached(
			"ExitElementContainer", typeof(bool), 
			typeof(global::Microsoft.UI.Xaml.Media.Animation.ContinuumNavigationTransitionInfo), 
			new Microsoft.UI.Xaml.FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.UI.Xaml.DependencyProperty ExitElementProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(ExitElement), typeof(global::Microsoft.UI.Xaml.UIElement), 
			typeof(global::Microsoft.UI.Xaml.Media.Animation.ContinuumNavigationTransitionInfo), 
			new Microsoft.UI.Xaml.FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.UIElement)));
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.UI.Xaml.DependencyProperty IsEntranceElementProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.RegisterAttached(
			"IsEntranceElement", typeof(bool), 
			typeof(global::Microsoft.UI.Xaml.Media.Animation.ContinuumNavigationTransitionInfo), 
			new Microsoft.UI.Xaml.FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.UI.Xaml.DependencyProperty IsExitElementProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.RegisterAttached(
			"IsExitElement", typeof(bool), 
			typeof(global::Microsoft.UI.Xaml.Media.Animation.ContinuumNavigationTransitionInfo), 
			new Microsoft.UI.Xaml.FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public ContinuumNavigationTransitionInfo() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Media.Animation.ContinuumNavigationTransitionInfo", "ContinuumNavigationTransitionInfo.ContinuumNavigationTransitionInfo()");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.ContinuumNavigationTransitionInfo.ContinuumNavigationTransitionInfo()
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.ContinuumNavigationTransitionInfo.ExitElement.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.ContinuumNavigationTransitionInfo.ExitElement.set
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.ContinuumNavigationTransitionInfo.ExitElementProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.ContinuumNavigationTransitionInfo.IsEntranceElementProperty.get
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static bool GetIsEntranceElement( global::Microsoft.UI.Xaml.UIElement element)
		{
			return (bool)element.GetValue(IsEntranceElementProperty);
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static void SetIsEntranceElement( global::Microsoft.UI.Xaml.UIElement element,  bool value)
		{
			element.SetValue(IsEntranceElementProperty, value);
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.ContinuumNavigationTransitionInfo.IsExitElementProperty.get
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static bool GetIsExitElement( global::Microsoft.UI.Xaml.UIElement element)
		{
			return (bool)element.GetValue(IsExitElementProperty);
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static void SetIsExitElement( global::Microsoft.UI.Xaml.UIElement element,  bool value)
		{
			element.SetValue(IsExitElementProperty, value);
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.ContinuumNavigationTransitionInfo.ExitElementContainerProperty.get
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static bool GetExitElementContainer( global::Microsoft.UI.Xaml.Controls.ListViewBase element)
		{
			return (bool)element.GetValue(ExitElementContainerProperty);
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static void SetExitElementContainer( global::Microsoft.UI.Xaml.Controls.ListViewBase element,  bool value)
		{
			element.SetValue(ExitElementContainerProperty, value);
		}
		#endif
	}
}
