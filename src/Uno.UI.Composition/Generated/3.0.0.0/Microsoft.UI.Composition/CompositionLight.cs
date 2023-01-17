#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Composition
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || false
	[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__")]
	#endif
	public  partial class CompositionLight : global::Microsoft.UI.Composition.CompositionObject
	{
		#if __ANDROID__ || __IOS__ || false || __WASM__ || false || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__WASM__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Composition.VisualUnorderedCollection Targets
		{
			get
			{
				throw new global::System.NotImplementedException("The member VisualUnorderedCollection CompositionLight.Targets is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || false || __WASM__ || false || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__WASM__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Composition.VisualUnorderedCollection ExclusionsFromTargets
		{
			get
			{
				throw new global::System.NotImplementedException("The member VisualUnorderedCollection CompositionLight.ExclusionsFromTargets is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || false || __WASM__ || false || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__WASM__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool IsEnabled
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool CompositionLight.IsEnabled is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.CompositionLight", "bool CompositionLight.IsEnabled");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Composition.CompositionLight.ExclusionsFromTargets.get
		// Forced skipping of method Microsoft.UI.Composition.CompositionLight.IsEnabled.set
		// Forced skipping of method Microsoft.UI.Composition.CompositionLight.Targets.get
		// Forced skipping of method Microsoft.UI.Composition.CompositionLight.IsEnabled.get
	}
}