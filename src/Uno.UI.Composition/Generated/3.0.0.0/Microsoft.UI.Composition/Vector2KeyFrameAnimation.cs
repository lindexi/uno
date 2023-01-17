#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Composition
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || false
	[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__")]
	#endif
	public  partial class Vector2KeyFrameAnimation : global::Microsoft.UI.Composition.KeyFrameAnimation
	{
		#if __ANDROID__ || __IOS__ || false || __WASM__ || false || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__WASM__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void InsertKeyFrame( float normalizedProgressKey,  global::System.Numerics.Vector2 value,  global::Microsoft.UI.Composition.CompositionEasingFunction easingFunction)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.Vector2KeyFrameAnimation", "void Vector2KeyFrameAnimation.InsertKeyFrame(float normalizedProgressKey, Vector2 value, CompositionEasingFunction easingFunction)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || false || __WASM__ || false || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__WASM__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void InsertKeyFrame( float normalizedProgressKey,  global::System.Numerics.Vector2 value)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.Vector2KeyFrameAnimation", "void Vector2KeyFrameAnimation.InsertKeyFrame(float normalizedProgressKey, Vector2 value)");
		}
		#endif
	}
}