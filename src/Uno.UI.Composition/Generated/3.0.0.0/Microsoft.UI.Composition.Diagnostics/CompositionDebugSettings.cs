#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Composition.Diagnostics
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || false
	[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__")]
	#endif
	public  partial class CompositionDebugSettings 
	{
		#if __ANDROID__ || __IOS__ || false || __WASM__ || false || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__WASM__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Composition.Diagnostics.CompositionDebugHeatMaps HeatMaps
		{
			get
			{
				throw new global::System.NotImplementedException("The member CompositionDebugHeatMaps CompositionDebugSettings.HeatMaps is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Composition.Diagnostics.CompositionDebugSettings.HeatMaps.get
		#if __ANDROID__ || __IOS__ || false || __WASM__ || false || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__WASM__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.UI.Composition.Diagnostics.CompositionDebugSettings TryGetSettings( global::Microsoft.UI.Composition.Compositor compositor)
		{
			throw new global::System.NotImplementedException("The member CompositionDebugSettings CompositionDebugSettings.TryGetSettings(Compositor compositor) is not implemented in Uno.");
		}
		#endif
	}
}