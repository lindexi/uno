#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Composition
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || false
	[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__")]
	#endif
	public static partial class CompositionApiInformation 
	{
		#if __ANDROID__ || __IOS__ || false || __WASM__ || false || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__WASM__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static ulong ApiVersion
		{
			get
			{
				throw new global::System.NotImplementedException("The member ulong CompositionApiInformation.ApiVersion is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Composition.CompositionApiInformation.ApiVersion.get
	}
}