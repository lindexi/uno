#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Composition
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class CompositionEffectBrush : global::Windows.UI.Composition.CompositionBrush
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.Composition.CompositionBrush GetSourceParameter( string name)
		{
			throw new global::System.NotImplementedException("The member CompositionBrush CompositionEffectBrush.GetSourceParameter(string name) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=CompositionBrush%20CompositionEffectBrush.GetSourceParameter%28string%20name%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void SetSourceParameter( string name,  global::Windows.UI.Composition.CompositionBrush source)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Composition.CompositionEffectBrush", "void CompositionEffectBrush.SetSourceParameter(string name, CompositionBrush source)");
		}
		#endif
	}
}