#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Composition.Scenes
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || false
	public   enum SceneWrappingMode 
	{
		#if __ANDROID__ || __IOS__ || false || __WASM__ || false || __NETSTD_REFERENCE__ || __MACOS__
		ClampToEdge = 0,
		#endif
		#if __ANDROID__ || __IOS__ || false || __WASM__ || false || __NETSTD_REFERENCE__ || __MACOS__
		MirroredRepeat = 1,
		#endif
		#if __ANDROID__ || __IOS__ || false || __WASM__ || false || __NETSTD_REFERENCE__ || __MACOS__
		Repeat = 2,
		#endif
	}
	#endif
}