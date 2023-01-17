#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Composition
{
	#if false || false || NET461 || __WASM__ || __SKIA__ || false || false
	[global::Uno.NotImplemented("NET461", "__WASM__", "__SKIA__")]
	#endif
	public  partial class LayerVisual : global::Microsoft.UI.Composition.ContainerVisual
	{
		#if __ANDROID__ || __IOS__ || false || __WASM__ || false || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__WASM__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Composition.CompositionEffectBrush Effect
		{
			get
			{
				throw new global::System.NotImplementedException("The member CompositionEffectBrush LayerVisual.Effect is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.LayerVisual", "CompositionEffectBrush LayerVisual.Effect");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || false || __WASM__ || false || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__WASM__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Composition.CompositionShadow Shadow
		{
			get
			{
				throw new global::System.NotImplementedException("The member CompositionShadow LayerVisual.Shadow is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.LayerVisual", "CompositionShadow LayerVisual.Shadow");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Composition.LayerVisual.Effect.get
		// Forced skipping of method Microsoft.UI.Composition.LayerVisual.Shadow.get
		// Forced skipping of method Microsoft.UI.Composition.LayerVisual.Effect.set
		// Forced skipping of method Microsoft.UI.Composition.LayerVisual.Shadow.set
	}
}