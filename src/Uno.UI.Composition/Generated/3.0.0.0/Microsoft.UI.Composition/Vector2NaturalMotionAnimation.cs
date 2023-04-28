#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Composition
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class Vector2NaturalMotionAnimation : global::Microsoft.UI.Composition.NaturalMotionAnimation
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Numerics.Vector2 InitialVelocity
		{
			get
			{
				throw new global::System.NotImplementedException("The member Vector2 Vector2NaturalMotionAnimation.InitialVelocity is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=Vector2%20Vector2NaturalMotionAnimation.InitialVelocity");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.Vector2NaturalMotionAnimation", "Vector2 Vector2NaturalMotionAnimation.InitialVelocity");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Numerics.Vector2? InitialValue
		{
			get
			{
				throw new global::System.NotImplementedException("The member Vector2? Vector2NaturalMotionAnimation.InitialValue is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=Vector2%3F%20Vector2NaturalMotionAnimation.InitialValue");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.Vector2NaturalMotionAnimation", "Vector2? Vector2NaturalMotionAnimation.InitialValue");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Numerics.Vector2? FinalValue
		{
			get
			{
				throw new global::System.NotImplementedException("The member Vector2? Vector2NaturalMotionAnimation.FinalValue is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=Vector2%3F%20Vector2NaturalMotionAnimation.FinalValue");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.Vector2NaturalMotionAnimation", "Vector2? Vector2NaturalMotionAnimation.FinalValue");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Composition.Vector2NaturalMotionAnimation.InitialValue.get
		// Forced skipping of method Microsoft.UI.Composition.Vector2NaturalMotionAnimation.InitialVelocity.get
		// Forced skipping of method Microsoft.UI.Composition.Vector2NaturalMotionAnimation.InitialVelocity.set
		// Forced skipping of method Microsoft.UI.Composition.Vector2NaturalMotionAnimation.InitialValue.set
		// Forced skipping of method Microsoft.UI.Composition.Vector2NaturalMotionAnimation.FinalValue.get
		// Forced skipping of method Microsoft.UI.Composition.Vector2NaturalMotionAnimation.FinalValue.set
	}
}