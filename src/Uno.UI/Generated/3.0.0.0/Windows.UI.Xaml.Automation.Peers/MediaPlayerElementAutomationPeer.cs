#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Automation.Peers
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class MediaPlayerElementAutomationPeer : global::Windows.UI.Xaml.Automation.Peers.FrameworkElementAutomationPeer
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public MediaPlayerElementAutomationPeer( global::Windows.UI.Xaml.Controls.MediaPlayerElement owner) : base(owner)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Automation.Peers.MediaPlayerElementAutomationPeer", "MediaPlayerElementAutomationPeer.MediaPlayerElementAutomationPeer(MediaPlayerElement owner)");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Automation.Peers.MediaPlayerElementAutomationPeer.MediaPlayerElementAutomationPeer(Windows.UI.Xaml.Controls.MediaPlayerElement)
	}
}