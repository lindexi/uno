#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Windowing
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class AppWindowPresenter 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Windowing.AppWindowPresenterKind Kind
		{
			get
			{
				throw new global::System.NotImplementedException("The member AppWindowPresenterKind AppWindowPresenter.Kind is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=AppWindowPresenterKind%20AppWindowPresenter.Kind");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Windowing.AppWindowPresenter.Kind.get
	}
}