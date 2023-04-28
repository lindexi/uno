#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Automation.Peers
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class FlipViewItemDataAutomationPeer : global::Microsoft.UI.Xaml.Automation.Peers.SelectorItemAutomationPeer,global::Microsoft.UI.Xaml.Automation.Provider.IScrollItemProvider
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public FlipViewItemDataAutomationPeer( object item,  global::Microsoft.UI.Xaml.Automation.Peers.FlipViewAutomationPeer parent) : base(item, parent)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Automation.Peers.FlipViewItemDataAutomationPeer", "FlipViewItemDataAutomationPeer.FlipViewItemDataAutomationPeer(object item, FlipViewAutomationPeer parent)");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Automation.Peers.FlipViewItemDataAutomationPeer.FlipViewItemDataAutomationPeer(object, Microsoft.UI.Xaml.Automation.Peers.FlipViewAutomationPeer)
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void ScrollIntoView()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Automation.Peers.FlipViewItemDataAutomationPeer", "void FlipViewItemDataAutomationPeer.ScrollIntoView()");
		}
		#endif
		// Processing: Microsoft.UI.Xaml.Automation.Provider.IScrollItemProvider
	}
}