#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Composition
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || false
	[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__")]
	#endif
	public  partial class AmbientLight : global::Microsoft.UI.Composition.CompositionLight
	{
		#if __ANDROID__ || __IOS__ || false || __WASM__ || false || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__WASM__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.Color Color
		{
			get
			{
				throw new global::System.NotImplementedException("The member Color AmbientLight.Color is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.AmbientLight", "Color AmbientLight.Color");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || false || __WASM__ || false || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__WASM__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  float Intensity
		{
			get
			{
				throw new global::System.NotImplementedException("The member float AmbientLight.Intensity is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.AmbientLight", "float AmbientLight.Intensity");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Composition.AmbientLight.Intensity.get
		// Forced skipping of method Microsoft.UI.Composition.AmbientLight.Color.set
		// Forced skipping of method Microsoft.UI.Composition.AmbientLight.Color.get
		// Forced skipping of method Microsoft.UI.Composition.AmbientLight.Intensity.set
	}
}