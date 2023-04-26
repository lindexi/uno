#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls
{
	#if false || false || false || false || false || false || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class AnimatedVisualPlayer : global::Microsoft.UI.Xaml.FrameworkElement
	{
		// Skipping already declared property Stretch
		// Skipping already declared property Source
		// Skipping already declared property PlaybackRate
		// Skipping already declared property FallbackContent
		// Skipping already declared property AutoPlay
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  object Diagnostics
		{
			get
			{
				return (object)this.GetValue(DiagnosticsProperty);
			}
		}
		#endif
		// Skipping already declared property Duration
		// Skipping already declared property IsAnimatedVisualLoaded
		// Skipping already declared property IsPlaying
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Composition.CompositionObject ProgressObject
		{
			get
			{
				throw new global::System.NotImplementedException("The member CompositionObject AnimatedVisualPlayer.ProgressObject is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=CompositionObject%20AnimatedVisualPlayer.ProgressObject");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Xaml.Controls.PlayerAnimationOptimization AnimationOptimization
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Controls.PlayerAnimationOptimization)this.GetValue(AnimationOptimizationProperty);
			}
			set
			{
				this.SetValue(AnimationOptimizationProperty, value);
			}
		}
		#endif
		// Skipping already declared property AutoPlayProperty
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.UI.Xaml.DependencyProperty DiagnosticsProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(Diagnostics), typeof(object), 
			typeof(global::Microsoft.UI.Xaml.Controls.AnimatedVisualPlayer), 
			new Microsoft.UI.Xaml.FrameworkPropertyMetadata(default(object)));
		#endif
		// Skipping already declared property DurationProperty
		// Skipping already declared property FallbackContentProperty
		// Skipping already declared property IsAnimatedVisualLoadedProperty
		// Skipping already declared property IsPlayingProperty
		// Skipping already declared property PlaybackRateProperty
		// Skipping already declared property SourceProperty
		// Skipping already declared property StretchProperty
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.UI.Xaml.DependencyProperty AnimationOptimizationProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(AnimationOptimization), typeof(global::Microsoft.UI.Xaml.Controls.PlayerAnimationOptimization), 
			typeof(global::Microsoft.UI.Xaml.Controls.AnimatedVisualPlayer), 
			new Microsoft.UI.Xaml.FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Controls.PlayerAnimationOptimization)));
		#endif
		// Skipping already declared method Microsoft.UI.Xaml.Controls.AnimatedVisualPlayer.AnimatedVisualPlayer()
		// Forced skipping of method Microsoft.UI.Xaml.Controls.AnimatedVisualPlayer.AnimatedVisualPlayer()
		// Forced skipping of method Microsoft.UI.Xaml.Controls.AnimatedVisualPlayer.Diagnostics.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.AnimatedVisualPlayer.Duration.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.AnimatedVisualPlayer.Source.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.AnimatedVisualPlayer.Source.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.AnimatedVisualPlayer.FallbackContent.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.AnimatedVisualPlayer.FallbackContent.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.AnimatedVisualPlayer.AutoPlay.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.AnimatedVisualPlayer.AutoPlay.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.AnimatedVisualPlayer.IsAnimatedVisualLoaded.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.AnimatedVisualPlayer.IsPlaying.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.AnimatedVisualPlayer.PlaybackRate.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.AnimatedVisualPlayer.PlaybackRate.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.AnimatedVisualPlayer.ProgressObject.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.AnimatedVisualPlayer.Stretch.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.AnimatedVisualPlayer.Stretch.set
		// Skipping already declared method Microsoft.UI.Xaml.Controls.AnimatedVisualPlayer.Pause()
		// Skipping already declared method Microsoft.UI.Xaml.Controls.AnimatedVisualPlayer.PlayAsync(double, double, bool)
		// Skipping already declared method Microsoft.UI.Xaml.Controls.AnimatedVisualPlayer.Resume()
		// Skipping already declared method Microsoft.UI.Xaml.Controls.AnimatedVisualPlayer.SetProgress(double)
		// Skipping already declared method Microsoft.UI.Xaml.Controls.AnimatedVisualPlayer.Stop()
		// Forced skipping of method Microsoft.UI.Xaml.Controls.AnimatedVisualPlayer.AnimationOptimization.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.AnimatedVisualPlayer.AnimationOptimization.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.AnimatedVisualPlayer.AnimationOptimizationProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.AnimatedVisualPlayer.AutoPlayProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.AnimatedVisualPlayer.DiagnosticsProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.AnimatedVisualPlayer.DurationProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.AnimatedVisualPlayer.FallbackContentProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.AnimatedVisualPlayer.IsAnimatedVisualLoadedProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.AnimatedVisualPlayer.IsPlayingProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.AnimatedVisualPlayer.PlaybackRateProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.AnimatedVisualPlayer.SourceProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.AnimatedVisualPlayer.StretchProperty.get
	}
}
