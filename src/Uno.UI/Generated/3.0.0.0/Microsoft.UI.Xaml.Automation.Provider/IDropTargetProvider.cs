#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Automation.Provider
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial interface IDropTargetProvider 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		string DropEffect
		{
			get;
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		string[] DropEffects
		{
			get;
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Automation.Provider.IDropTargetProvider.DropEffect.get
		// Forced skipping of method Microsoft.UI.Xaml.Automation.Provider.IDropTargetProvider.DropEffects.get
	}
}
