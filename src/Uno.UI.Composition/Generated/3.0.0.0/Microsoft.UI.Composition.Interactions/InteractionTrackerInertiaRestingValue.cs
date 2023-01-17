#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Composition.Interactions
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || false
	[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__")]
	#endif
	public  partial class InteractionTrackerInertiaRestingValue : global::Microsoft.UI.Composition.Interactions.InteractionTrackerInertiaModifier
	{
		#if __ANDROID__ || __IOS__ || false || __WASM__ || false || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__WASM__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Composition.ExpressionAnimation RestingValue
		{
			get
			{
				throw new global::System.NotImplementedException("The member ExpressionAnimation InteractionTrackerInertiaRestingValue.RestingValue is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.Interactions.InteractionTrackerInertiaRestingValue", "ExpressionAnimation InteractionTrackerInertiaRestingValue.RestingValue");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || false || __WASM__ || false || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__WASM__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Composition.ExpressionAnimation Condition
		{
			get
			{
				throw new global::System.NotImplementedException("The member ExpressionAnimation InteractionTrackerInertiaRestingValue.Condition is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.Interactions.InteractionTrackerInertiaRestingValue", "ExpressionAnimation InteractionTrackerInertiaRestingValue.Condition");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Composition.Interactions.InteractionTrackerInertiaRestingValue.Condition.get
		// Forced skipping of method Microsoft.UI.Composition.Interactions.InteractionTrackerInertiaRestingValue.RestingValue.set
		// Forced skipping of method Microsoft.UI.Composition.Interactions.InteractionTrackerInertiaRestingValue.Condition.set
		// Forced skipping of method Microsoft.UI.Composition.Interactions.InteractionTrackerInertiaRestingValue.RestingValue.get
		#if __ANDROID__ || __IOS__ || false || __WASM__ || false || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__WASM__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.UI.Composition.Interactions.InteractionTrackerInertiaRestingValue Create( global::Microsoft.UI.Composition.Compositor compositor)
		{
			throw new global::System.NotImplementedException("The member InteractionTrackerInertiaRestingValue InteractionTrackerInertiaRestingValue.Create(Compositor compositor) is not implemented in Uno.");
		}
		#endif
	}
}