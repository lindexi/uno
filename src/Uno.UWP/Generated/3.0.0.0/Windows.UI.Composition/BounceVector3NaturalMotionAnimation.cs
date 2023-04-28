#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Composition
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class BounceVector3NaturalMotionAnimation : global::Windows.UI.Composition.Vector3NaturalMotionAnimation
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  float Restitution
		{
			get
			{
				throw new global::System.NotImplementedException("The member float BounceVector3NaturalMotionAnimation.Restitution is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=float%20BounceVector3NaturalMotionAnimation.Restitution");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Composition.BounceVector3NaturalMotionAnimation", "float BounceVector3NaturalMotionAnimation.Restitution");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  float Acceleration
		{
			get
			{
				throw new global::System.NotImplementedException("The member float BounceVector3NaturalMotionAnimation.Acceleration is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=float%20BounceVector3NaturalMotionAnimation.Acceleration");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Composition.BounceVector3NaturalMotionAnimation", "float BounceVector3NaturalMotionAnimation.Acceleration");
			}
		}
		#endif
		// Forced skipping of method Windows.UI.Composition.BounceVector3NaturalMotionAnimation.Acceleration.get
		// Forced skipping of method Windows.UI.Composition.BounceVector3NaturalMotionAnimation.Acceleration.set
		// Forced skipping of method Windows.UI.Composition.BounceVector3NaturalMotionAnimation.Restitution.get
		// Forced skipping of method Windows.UI.Composition.BounceVector3NaturalMotionAnimation.Restitution.set
	}
}