#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class ListBox : global::Microsoft.UI.Xaml.Controls.Primitives.Selector
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool SingleSelectionFollowsFocus
		{
			get
			{
				return (bool)this.GetValue(SingleSelectionFollowsFocusProperty);
			}
			set
			{
				this.SetValue(SingleSelectionFollowsFocusProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Xaml.Controls.SelectionMode SelectionMode
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Controls.SelectionMode)this.GetValue(SelectionModeProperty);
			}
			set
			{
				this.SetValue(SelectionModeProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Collections.Generic.IList<object> SelectedItems
		{
			get
			{
				throw new global::System.NotImplementedException("The member IList<object> ListBox.SelectedItems is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.UI.Xaml.DependencyProperty SelectionModeProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(SelectionMode), typeof(global::Microsoft.UI.Xaml.Controls.SelectionMode), 
			typeof(global::Microsoft.UI.Xaml.Controls.ListBox), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Controls.SelectionMode)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.UI.Xaml.DependencyProperty SingleSelectionFollowsFocusProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(SingleSelectionFollowsFocus), typeof(bool), 
			typeof(global::Microsoft.UI.Xaml.Controls.ListBox), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public ListBox() 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.ListBox", "ListBox.ListBox()");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ListBox.ListBox()
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ListBox.SelectedItems.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ListBox.SelectionMode.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ListBox.SelectionMode.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ListBox.SingleSelectionFollowsFocus.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ListBox.SingleSelectionFollowsFocus.set
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void ScrollIntoView( object item)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.ListBox", "void ListBox.ScrollIntoView(object item)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void SelectAll()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.ListBox", "void ListBox.SelectAll()");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ListBox.SelectionModeProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ListBox.SingleSelectionFollowsFocusProperty.get
	}
}