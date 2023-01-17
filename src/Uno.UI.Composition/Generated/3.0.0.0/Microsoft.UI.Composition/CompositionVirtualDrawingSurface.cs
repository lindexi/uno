#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Composition
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || false
	[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__")]
	#endif
	public  partial class CompositionVirtualDrawingSurface : global::Microsoft.UI.Composition.CompositionDrawingSurface
	{
		#if __ANDROID__ || __IOS__ || false || __WASM__ || false || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__WASM__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void Trim( global::Windows.Graphics.RectInt32[] rects)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.CompositionVirtualDrawingSurface", "void CompositionVirtualDrawingSurface.Trim(RectInt32[] rects)");
		}
		#endif
	}
}