#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Composition
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || false
	[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__")]
	#endif
	public  partial class RenderingDeviceReplacedEventArgs : global::Microsoft.UI.Composition.CompositionObject
	{
		#if __ANDROID__ || __IOS__ || false || __WASM__ || false || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__WASM__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Composition.CompositionGraphicsDevice GraphicsDevice
		{
			get
			{
				throw new global::System.NotImplementedException("The member CompositionGraphicsDevice RenderingDeviceReplacedEventArgs.GraphicsDevice is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Composition.RenderingDeviceReplacedEventArgs.GraphicsDevice.get
	}
}