#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Printing
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	public delegate void GetPreviewPageEventHandler(object sender, global::Microsoft.UI.Xaml.Printing.GetPreviewPageEventArgs e);
	#endif
}