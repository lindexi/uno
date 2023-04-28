#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml
{
	#if false || false || false || false || false || false || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class Application 
	{
		// Skipping already declared property Resources
		// Skipping already declared property RequestedTheme
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Xaml.ApplicationHighContrastAdjustment HighContrastAdjustment
		{
			get
			{
				throw new global::System.NotImplementedException("The member ApplicationHighContrastAdjustment Application.HighContrastAdjustment is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=ApplicationHighContrastAdjustment%20Application.HighContrastAdjustment");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Application", "ApplicationHighContrastAdjustment Application.HighContrastAdjustment");
			}
		}
		#endif
		// Skipping already declared property FocusVisualKind
		// Skipping already declared property DebugSettings
		// Skipping already declared property Current
		// Skipping already declared method Microsoft.UI.Xaml.Application.Application()
		// Forced skipping of method Microsoft.UI.Xaml.Application.Application()
		// Forced skipping of method Microsoft.UI.Xaml.Application.Resources.get
		// Forced skipping of method Microsoft.UI.Xaml.Application.Resources.set
		// Forced skipping of method Microsoft.UI.Xaml.Application.DebugSettings.get
		// Forced skipping of method Microsoft.UI.Xaml.Application.RequestedTheme.get
		// Forced skipping of method Microsoft.UI.Xaml.Application.RequestedTheme.set
		// Forced skipping of method Microsoft.UI.Xaml.Application.FocusVisualKind.get
		// Forced skipping of method Microsoft.UI.Xaml.Application.FocusVisualKind.set
		// Forced skipping of method Microsoft.UI.Xaml.Application.HighContrastAdjustment.get
		// Forced skipping of method Microsoft.UI.Xaml.Application.HighContrastAdjustment.set
		// Forced skipping of method Microsoft.UI.Xaml.Application.UnhandledException.add
		// Forced skipping of method Microsoft.UI.Xaml.Application.UnhandledException.remove
		// Skipping already declared method Microsoft.UI.Xaml.Application.Exit()
		// Skipping already declared method Microsoft.UI.Xaml.Application.OnLaunched(Microsoft.UI.Xaml.LaunchActivatedEventArgs)
		// Forced skipping of method Microsoft.UI.Xaml.Application.Current.get
		// Skipping already declared method Microsoft.UI.Xaml.Application.Start(Microsoft.UI.Xaml.ApplicationInitializationCallback)
		// Skipping already declared method Microsoft.UI.Xaml.Application.LoadComponent(object, System.Uri)
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static void LoadComponent( object component,  global::System.Uri resourceLocator,  global::Microsoft.UI.Xaml.Controls.Primitives.ComponentResourceLocation componentResourceLocation)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Application", "void Application.LoadComponent(object component, Uri resourceLocator, ComponentResourceLocation componentResourceLocation)");
		}
		#endif
		// Skipping already declared event Microsoft.UI.Xaml.Application.UnhandledException
	}
}