#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Input
{
	#if false || false || false || false || false || false || false
	public   enum PointerDeviceType 
	{
		// Skipping already declared field Microsoft.UI.Input.PointerDeviceType.Touch
		// Skipping already declared field Microsoft.UI.Input.PointerDeviceType.Pen
		// Skipping already declared field Microsoft.UI.Input.PointerDeviceType.Mouse
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		Touchpad = 3,
		#endif
	}
	#endif
}