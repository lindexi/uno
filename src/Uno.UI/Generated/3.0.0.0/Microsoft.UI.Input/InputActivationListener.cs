#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Input
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class InputActivationListener : global::Microsoft.UI.Input.InputObject
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Input.InputActivationState State
		{
			get
			{
				throw new global::System.NotImplementedException("The member InputActivationState InputActivationListener.State is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Input.InputActivationListener.InputActivationChanged.add
		// Forced skipping of method Microsoft.UI.Input.InputActivationListener.State.get
		// Forced skipping of method Microsoft.UI.Input.InputActivationListener.InputActivationChanged.remove
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.UI.Input.InputActivationListener GetForWindowId( global::Microsoft.UI.WindowId windowId)
		{
			throw new global::System.NotImplementedException("The member InputActivationListener InputActivationListener.GetForWindowId(WindowId windowId) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Input.InputActivationListener, global::Microsoft.UI.Input.InputActivationListenerActivationChangedEventArgs> InputActivationChanged
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Input.InputActivationListener", "event TypedEventHandler<InputActivationListener, InputActivationListenerActivationChangedEventArgs> InputActivationListener.InputActivationChanged");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Input.InputActivationListener", "event TypedEventHandler<InputActivationListener, InputActivationListenerActivationChangedEventArgs> InputActivationListener.InputActivationChanged");
			}
		}
		#endif
	}
}