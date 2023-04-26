#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml
{
	#if false || false || false || false || false || false || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class VisualStateManager : global::Microsoft.UI.Xaml.DependencyObject
	{
		// Skipping already declared property CustomVisualStateManagerProperty
		// Skipping already declared method Microsoft.UI.Xaml.VisualStateManager.VisualStateManager()
		// Forced skipping of method Microsoft.UI.Xaml.VisualStateManager.VisualStateManager()
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		protected  void RaiseCurrentStateChanging( global::Microsoft.UI.Xaml.VisualStateGroup stateGroup,  global::Microsoft.UI.Xaml.VisualState oldState,  global::Microsoft.UI.Xaml.VisualState newState,  global::Microsoft.UI.Xaml.Controls.Control control)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.VisualStateManager", "void VisualStateManager.RaiseCurrentStateChanging(VisualStateGroup stateGroup, VisualState oldState, VisualState newState, Control control)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		protected  void RaiseCurrentStateChanged( global::Microsoft.UI.Xaml.VisualStateGroup stateGroup,  global::Microsoft.UI.Xaml.VisualState oldState,  global::Microsoft.UI.Xaml.VisualState newState,  global::Microsoft.UI.Xaml.Controls.Control control)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.VisualStateManager", "void VisualStateManager.RaiseCurrentStateChanged(VisualStateGroup stateGroup, VisualState oldState, VisualState newState, Control control)");
		}
		#endif
		// Skipping already declared method Microsoft.UI.Xaml.VisualStateManager.GoToStateCore(Microsoft.UI.Xaml.Controls.Control, Microsoft.UI.Xaml.FrameworkElement, string, Microsoft.UI.Xaml.VisualStateGroup, Microsoft.UI.Xaml.VisualState, bool)
		// Skipping already declared method Microsoft.UI.Xaml.VisualStateManager.GetVisualStateGroups(Microsoft.UI.Xaml.FrameworkElement)
		// Forced skipping of method Microsoft.UI.Xaml.VisualStateManager.CustomVisualStateManagerProperty.get
		// Skipping already declared method Microsoft.UI.Xaml.VisualStateManager.GetCustomVisualStateManager(Microsoft.UI.Xaml.FrameworkElement)
		// Skipping already declared method Microsoft.UI.Xaml.VisualStateManager.SetCustomVisualStateManager(Microsoft.UI.Xaml.FrameworkElement, Microsoft.UI.Xaml.VisualStateManager)
		// Skipping already declared method Microsoft.UI.Xaml.VisualStateManager.GoToState(Microsoft.UI.Xaml.Controls.Control, string, bool)
	}
}
