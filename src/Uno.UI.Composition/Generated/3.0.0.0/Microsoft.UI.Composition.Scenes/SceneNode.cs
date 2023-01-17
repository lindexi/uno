#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Composition.Scenes
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || false
	[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__")]
	#endif
	public  partial class SceneNode : global::Microsoft.UI.Composition.Scenes.SceneObject
	{
		#if __ANDROID__ || __IOS__ || false || __WASM__ || false || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__WASM__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Composition.Scenes.SceneNodeCollection Children
		{
			get
			{
				throw new global::System.NotImplementedException("The member SceneNodeCollection SceneNode.Children is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || false || __WASM__ || false || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__WASM__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Composition.Scenes.SceneComponentCollection Components
		{
			get
			{
				throw new global::System.NotImplementedException("The member SceneComponentCollection SceneNode.Components is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || false || __WASM__ || false || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__WASM__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Composition.Scenes.SceneNode Parent
		{
			get
			{
				throw new global::System.NotImplementedException("The member SceneNode SceneNode.Parent is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || false || __WASM__ || false || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__WASM__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Composition.Scenes.SceneModelTransform Transform
		{
			get
			{
				throw new global::System.NotImplementedException("The member SceneModelTransform SceneNode.Transform is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Composition.Scenes.SceneNode.Parent.get
		// Forced skipping of method Microsoft.UI.Composition.Scenes.SceneNode.Transform.get
		// Forced skipping of method Microsoft.UI.Composition.Scenes.SceneNode.Components.get
		#if __ANDROID__ || __IOS__ || false || __WASM__ || false || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__WASM__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Composition.Scenes.SceneComponent FindFirstComponentOfType( global::Microsoft.UI.Composition.Scenes.SceneComponentType value)
		{
			throw new global::System.NotImplementedException("The member SceneComponent SceneNode.FindFirstComponentOfType(SceneComponentType value) is not implemented in Uno.");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Composition.Scenes.SceneNode.Children.get
		#if __ANDROID__ || __IOS__ || false || __WASM__ || false || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__WASM__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.UI.Composition.Scenes.SceneNode Create( global::Microsoft.UI.Composition.Compositor compositor)
		{
			throw new global::System.NotImplementedException("The member SceneNode SceneNode.Create(Compositor compositor) is not implemented in Uno.");
		}
		#endif
	}
}