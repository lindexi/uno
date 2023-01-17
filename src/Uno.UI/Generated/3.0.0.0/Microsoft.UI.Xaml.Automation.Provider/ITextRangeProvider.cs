#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Automation.Provider
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial interface ITextRangeProvider 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		global::Microsoft.UI.Xaml.Automation.Provider.ITextRangeProvider Clone();
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		bool Compare( global::Microsoft.UI.Xaml.Automation.Provider.ITextRangeProvider textRangeProvider);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		int CompareEndpoints( global::Microsoft.UI.Xaml.Automation.Text.TextPatternRangeEndpoint endpoint,  global::Microsoft.UI.Xaml.Automation.Provider.ITextRangeProvider textRangeProvider,  global::Microsoft.UI.Xaml.Automation.Text.TextPatternRangeEndpoint targetEndpoint);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		void ExpandToEnclosingUnit( global::Microsoft.UI.Xaml.Automation.Text.TextUnit unit);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		global::Microsoft.UI.Xaml.Automation.Provider.ITextRangeProvider FindAttribute( int attributeId,  object value,  bool backward);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		global::Microsoft.UI.Xaml.Automation.Provider.ITextRangeProvider FindText( string text,  bool backward,  bool ignoreCase);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		object GetAttributeValue( int attributeId);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		void GetBoundingRectangles(out double[] returnValue);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		global::Microsoft.UI.Xaml.Automation.Provider.IRawElementProviderSimple GetEnclosingElement();
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		string GetText( int maxLength);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		int Move( global::Microsoft.UI.Xaml.Automation.Text.TextUnit unit,  int count);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		int MoveEndpointByUnit( global::Microsoft.UI.Xaml.Automation.Text.TextPatternRangeEndpoint endpoint,  global::Microsoft.UI.Xaml.Automation.Text.TextUnit unit,  int count);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		void MoveEndpointByRange( global::Microsoft.UI.Xaml.Automation.Text.TextPatternRangeEndpoint endpoint,  global::Microsoft.UI.Xaml.Automation.Provider.ITextRangeProvider textRangeProvider,  global::Microsoft.UI.Xaml.Automation.Text.TextPatternRangeEndpoint targetEndpoint);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		void Select();
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		void AddToSelection();
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		void RemoveFromSelection();
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		void ScrollIntoView( bool alignToTop);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		global::Microsoft.UI.Xaml.Automation.Provider.IRawElementProviderSimple[] GetChildren();
		#endif
	}
}