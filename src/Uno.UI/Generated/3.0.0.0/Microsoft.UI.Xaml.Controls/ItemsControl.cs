#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls
{
	#if false || false || false || false || false || false || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class ItemsControl : global::Microsoft.UI.Xaml.Controls.Control,global::Microsoft.UI.Xaml.Controls.IItemContainerMapping
	{
		// Skipping already declared property ItemsSource
		// Skipping already declared property ItemsPanel
		// Skipping already declared property ItemTemplateSelector
		// Skipping already declared property ItemTemplate
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Xaml.Media.Animation.TransitionCollection ItemContainerTransitions
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Media.Animation.TransitionCollection)this.GetValue(ItemContainerTransitionsProperty);
			}
			set
			{
				this.SetValue(ItemContainerTransitionsProperty, value);
			}
		}
		#endif
		// Skipping already declared property ItemContainerStyleSelector
		// Skipping already declared property ItemContainerStyle
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Xaml.Controls.GroupStyleSelector GroupStyleSelector
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Controls.GroupStyleSelector)this.GetValue(GroupStyleSelectorProperty);
			}
			set
			{
				this.SetValue(GroupStyleSelectorProperty, value);
			}
		}
		#endif
		// Skipping already declared property DisplayMemberPath
		// Skipping already declared property GroupStyle
		// Skipping already declared property IsGrouping
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Xaml.Controls.ItemContainerGenerator ItemContainerGenerator
		{
			get
			{
				throw new global::System.NotImplementedException("The member ItemContainerGenerator ItemsControl.ItemContainerGenerator is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=ItemContainerGenerator%20ItemsControl.ItemContainerGenerator");
			}
		}
		#endif
		// Skipping already declared property Items
		// Skipping already declared property ItemsPanelRoot
		// Skipping already declared property DisplayMemberPathProperty
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.UI.Xaml.DependencyProperty GroupStyleSelectorProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(GroupStyleSelector), typeof(global::Microsoft.UI.Xaml.Controls.GroupStyleSelector), 
			typeof(global::Microsoft.UI.Xaml.Controls.ItemsControl), 
			new Microsoft.UI.Xaml.FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Controls.GroupStyleSelector)));
		#endif
		// Skipping already declared property IsGroupingProperty
		// Skipping already declared property ItemContainerStyleProperty
		// Skipping already declared property ItemContainerStyleSelectorProperty
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.UI.Xaml.DependencyProperty ItemContainerTransitionsProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(ItemContainerTransitions), typeof(global::Microsoft.UI.Xaml.Media.Animation.TransitionCollection), 
			typeof(global::Microsoft.UI.Xaml.Controls.ItemsControl), 
			new Microsoft.UI.Xaml.FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Media.Animation.TransitionCollection)));
		#endif
		// Skipping already declared property ItemTemplateProperty
		// Skipping already declared property ItemTemplateSelectorProperty
		// Skipping already declared property ItemsPanelProperty
		// Skipping already declared property ItemsSourceProperty
		// Skipping already declared method Microsoft.UI.Xaml.Controls.ItemsControl.ItemsControl()
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ItemsControl.ItemsControl()
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ItemsControl.ItemsSource.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ItemsControl.ItemsSource.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ItemsControl.Items.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ItemsControl.ItemTemplate.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ItemsControl.ItemTemplate.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ItemsControl.ItemTemplateSelector.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ItemsControl.ItemTemplateSelector.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ItemsControl.ItemsPanel.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ItemsControl.ItemsPanel.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ItemsControl.DisplayMemberPath.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ItemsControl.DisplayMemberPath.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ItemsControl.ItemsPanelRoot.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ItemsControl.ItemContainerStyle.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ItemsControl.ItemContainerStyle.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ItemsControl.ItemContainerStyleSelector.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ItemsControl.ItemContainerStyleSelector.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ItemsControl.ItemContainerGenerator.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ItemsControl.ItemContainerTransitions.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ItemsControl.ItemContainerTransitions.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ItemsControl.GroupStyle.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ItemsControl.GroupStyleSelector.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ItemsControl.GroupStyleSelector.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ItemsControl.IsGrouping.get
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Xaml.DependencyObject GroupHeaderContainerFromItemContainer( global::Microsoft.UI.Xaml.DependencyObject itemContainer)
		{
			throw new global::System.NotImplementedException("The member DependencyObject ItemsControl.GroupHeaderContainerFromItemContainer(DependencyObject itemContainer) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=DependencyObject%20ItemsControl.GroupHeaderContainerFromItemContainer%28DependencyObject%20itemContainer%29");
		}
		#endif
		// Skipping already declared method Microsoft.UI.Xaml.Controls.ItemsControl.IsItemItsOwnContainerOverride(object)
		// Skipping already declared method Microsoft.UI.Xaml.Controls.ItemsControl.GetContainerForItemOverride()
		// Skipping already declared method Microsoft.UI.Xaml.Controls.ItemsControl.ClearContainerForItemOverride(Microsoft.UI.Xaml.DependencyObject, object)
		// Skipping already declared method Microsoft.UI.Xaml.Controls.ItemsControl.PrepareContainerForItemOverride(Microsoft.UI.Xaml.DependencyObject, object)
		// Skipping already declared method Microsoft.UI.Xaml.Controls.ItemsControl.OnItemsChanged(object)
		// Skipping already declared method Microsoft.UI.Xaml.Controls.ItemsControl.OnItemContainerStyleChanged(Microsoft.UI.Xaml.Style, Microsoft.UI.Xaml.Style)
		// Skipping already declared method Microsoft.UI.Xaml.Controls.ItemsControl.OnItemContainerStyleSelectorChanged(Microsoft.UI.Xaml.Controls.StyleSelector, Microsoft.UI.Xaml.Controls.StyleSelector)
		// Skipping already declared method Microsoft.UI.Xaml.Controls.ItemsControl.OnItemTemplateChanged(Microsoft.UI.Xaml.DataTemplate, Microsoft.UI.Xaml.DataTemplate)
		// Skipping already declared method Microsoft.UI.Xaml.Controls.ItemsControl.OnItemTemplateSelectorChanged(Microsoft.UI.Xaml.Controls.DataTemplateSelector, Microsoft.UI.Xaml.Controls.DataTemplateSelector)
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		protected virtual void OnGroupStyleSelectorChanged( global::Microsoft.UI.Xaml.Controls.GroupStyleSelector oldGroupStyleSelector,  global::Microsoft.UI.Xaml.Controls.GroupStyleSelector newGroupStyleSelector)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.ItemsControl", "void ItemsControl.OnGroupStyleSelectorChanged(GroupStyleSelector oldGroupStyleSelector, GroupStyleSelector newGroupStyleSelector)");
		}
		#endif
		// Skipping already declared method Microsoft.UI.Xaml.Controls.ItemsControl.ItemFromContainer(Microsoft.UI.Xaml.DependencyObject)
		// Skipping already declared method Microsoft.UI.Xaml.Controls.ItemsControl.ContainerFromItem(object)
		// Skipping already declared method Microsoft.UI.Xaml.Controls.ItemsControl.IndexFromContainer(Microsoft.UI.Xaml.DependencyObject)
		// Skipping already declared method Microsoft.UI.Xaml.Controls.ItemsControl.ContainerFromIndex(int)
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ItemsControl.ItemsSourceProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ItemsControl.ItemTemplateProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ItemsControl.ItemTemplateSelectorProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ItemsControl.ItemsPanelProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ItemsControl.DisplayMemberPathProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ItemsControl.ItemContainerStyleProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ItemsControl.ItemContainerStyleSelectorProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ItemsControl.ItemContainerTransitionsProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ItemsControl.GroupStyleSelectorProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ItemsControl.IsGroupingProperty.get
		// Skipping already declared method Microsoft.UI.Xaml.Controls.ItemsControl.GetItemsOwner(Microsoft.UI.Xaml.DependencyObject)
		// Skipping already declared method Microsoft.UI.Xaml.Controls.ItemsControl.ItemsControlFromItemContainer(Microsoft.UI.Xaml.DependencyObject)
		// Processing: Microsoft.UI.Xaml.Controls.IItemContainerMapping
	}
}
