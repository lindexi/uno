#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Composition.Interactions
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class InteractionTrackerInertiaNaturalMotion : global::Microsoft.UI.Composition.Interactions.InteractionTrackerInertiaModifier
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Composition.ScalarNaturalMotionAnimation NaturalMotion
		{
			get
			{
				throw new global::System.NotImplementedException("The member ScalarNaturalMotionAnimation InteractionTrackerInertiaNaturalMotion.NaturalMotion is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=ScalarNaturalMotionAnimation%20InteractionTrackerInertiaNaturalMotion.NaturalMotion");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.Interactions.InteractionTrackerInertiaNaturalMotion", "ScalarNaturalMotionAnimation InteractionTrackerInertiaNaturalMotion.NaturalMotion");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Composition.ExpressionAnimation Condition
		{
			get
			{
				throw new global::System.NotImplementedException("The member ExpressionAnimation InteractionTrackerInertiaNaturalMotion.Condition is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=ExpressionAnimation%20InteractionTrackerInertiaNaturalMotion.Condition");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.Interactions.InteractionTrackerInertiaNaturalMotion", "ExpressionAnimation InteractionTrackerInertiaNaturalMotion.Condition");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Composition.Interactions.InteractionTrackerInertiaNaturalMotion.Condition.set
		// Forced skipping of method Microsoft.UI.Composition.Interactions.InteractionTrackerInertiaNaturalMotion.NaturalMotion.get
		// Forced skipping of method Microsoft.UI.Composition.Interactions.InteractionTrackerInertiaNaturalMotion.NaturalMotion.set
		// Forced skipping of method Microsoft.UI.Composition.Interactions.InteractionTrackerInertiaNaturalMotion.Condition.get
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.UI.Composition.Interactions.InteractionTrackerInertiaNaturalMotion Create( global::Microsoft.UI.Composition.Compositor compositor)
		{
			throw new global::System.NotImplementedException("The member InteractionTrackerInertiaNaturalMotion InteractionTrackerInertiaNaturalMotion.Create(Compositor compositor) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=InteractionTrackerInertiaNaturalMotion%20InteractionTrackerInertiaNaturalMotion.Create%28Compositor%20compositor%29");
		}
		#endif
	}
}
