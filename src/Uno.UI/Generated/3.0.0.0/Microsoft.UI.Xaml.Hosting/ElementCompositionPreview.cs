#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Hosting
{
	#if false || false || false || false || false || false || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class ElementCompositionPreview 
	{
		// Skipping already declared method Microsoft.UI.Xaml.Hosting.ElementCompositionPreview.GetElementVisual(Microsoft.UI.Xaml.UIElement)
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.UI.Composition.Visual GetElementChildVisual( global::Microsoft.UI.Xaml.UIElement element)
		{
			throw new global::System.NotImplementedException("The member Visual ElementCompositionPreview.GetElementChildVisual(UIElement element) is not implemented in Uno.");
		}
		#endif
		#if false || false || false || __WASM__ || false || false || false
		[global::Uno.NotImplemented("__WASM__")]
		public static void SetElementChildVisual( global::Microsoft.UI.Xaml.UIElement element,  global::Microsoft.UI.Composition.Visual visual)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Hosting.ElementCompositionPreview", "void ElementCompositionPreview.SetElementChildVisual(UIElement element, Visual visual)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.UI.Composition.CompositionPropertySet GetScrollViewerManipulationPropertySet( global::Microsoft.UI.Xaml.Controls.ScrollViewer scrollViewer)
		{
			throw new global::System.NotImplementedException("The member CompositionPropertySet ElementCompositionPreview.GetScrollViewerManipulationPropertySet(ScrollViewer scrollViewer) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static void SetImplicitShowAnimation( global::Microsoft.UI.Xaml.UIElement element,  global::Microsoft.UI.Composition.ICompositionAnimationBase animation)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Hosting.ElementCompositionPreview", "void ElementCompositionPreview.SetImplicitShowAnimation(UIElement element, ICompositionAnimationBase animation)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static void SetImplicitHideAnimation( global::Microsoft.UI.Xaml.UIElement element,  global::Microsoft.UI.Composition.ICompositionAnimationBase animation)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Hosting.ElementCompositionPreview", "void ElementCompositionPreview.SetImplicitHideAnimation(UIElement element, ICompositionAnimationBase animation)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static void SetIsTranslationEnabled( global::Microsoft.UI.Xaml.UIElement element,  bool value)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Hosting.ElementCompositionPreview", "void ElementCompositionPreview.SetIsTranslationEnabled(UIElement element, bool value)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.UI.Composition.CompositionPropertySet GetPointerPositionPropertySet( global::Microsoft.UI.Xaml.UIElement targetElement)
		{
			throw new global::System.NotImplementedException("The member CompositionPropertySet ElementCompositionPreview.GetPointerPositionPropertySet(UIElement targetElement) is not implemented in Uno.");
		}
		#endif
	}
}