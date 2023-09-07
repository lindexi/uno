﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Uno.UI.Extensions;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Markup;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Private.Infrastructure;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Shapes;
using Windows.UI;

namespace Uno.UI.RuntimeTests.Tests.Windows_UI_Xaml
{
	[TestClass]
	public class Given_Control
	{
		[TestMethod]
		[RunsOnUIThread]
		public async Task When_SetChildTemplateUsingVisualState()
		{
			var parent = (Button)XamlReader.Load(_when_SetChildTemplateUsingVisualState);
			TestServices.WindowHelper.WindowContent = parent;
			await TestServices.WindowHelper.WaitForIdle();

			var tb = parent.FindFirstChild<TextBlock>();

			Assert.IsNotNull(tb);
			Assert.AreEqual("Template loaded!", tb.Text);
		}

		private const string _when_SetChildTemplateUsingVisualState =
			"""
			<Button xmlns='http://schemas.microsoft.com/winfx/2006/xaml/presentation' xmlns:x='http://schemas.microsoft.com/winfx/2006/xaml'>
				<Button.Template>
					<ControlTemplate TargetType="ContentControl">
						<Grid>
							<VisualStateManager.VisualStateGroups>
								<VisualStateGroup x:Name="CommonStates">
									<VisualState x:Name="Normal">
										<VisualState.Setters>
											<Setter  Target="_sut.Template">
												<Setter.Value>
													<ControlTemplate TargetType="ContentControl">
														<TextBlock Text="Template loaded!" />
													</ControlTemplate>
												</Setter.Value>
											</Setter>
										</VisualState.Setters>
									</VisualState>
								</VisualStateGroup>
							</VisualStateManager.VisualStateGroups>

							<ContentControl x:Name="_sut" />
						</Grid>
					</ControlTemplate>
				</Button.Template>
			</Button>
			""";

		[TestMethod]
		[RunsOnUIThread]
		public async Task When_Refresh_Setter_BindingOnInvocation()
		{
			var SUT = new When_Refresh_Setter_BindingOnInvocation();
			TestServices.WindowHelper.WindowContent = SUT;
			await TestServices.WindowHelper.WaitForIdle();

			SUT.root.Content = 42;

			var testTransform = (SUT.root.FindName("ContentElement") as FrameworkElement).RenderTransform as CompositeTransform;

			Assert.IsNotNull(testTransform);

			Assert.AreEqual(0, testTransform.TranslateX);

			VisualStateManager.GoToState(SUT.root, "Normal", false);
			await TestServices.WindowHelper.WaitForIdle();
			Assert.AreEqual(-10, testTransform.TranslateY);

			SUT.root.Tag = 42;
			VisualStateManager.GoToState(SUT.root, "Focused", false);
			await TestServices.WindowHelper.WaitForIdle();
			Assert.AreEqual(42, testTransform.TranslateY);

			SUT.root.Tag = 43;
			VisualStateManager.GoToState(SUT.root, "Normal", false);
			await TestServices.WindowHelper.WaitForIdle();
			Assert.AreEqual(43, testTransform.TranslateY);
		}

		[TestMethod]
		[RunsOnUIThread]
		public async Task When_Refresh_Setter_BindingOnInvocation_ElementName()
		{
			var SUT = new When_Refresh_Setter_BindingOnInvocation_ElementName();
			TestServices.WindowHelper.WindowContent = SUT;
			await TestServices.WindowHelper.WaitForIdle();

			SUT.root.Content = 42;

			var testTransform = (SUT.root.FindName("ContentElement") as FrameworkElement).RenderTransform as CompositeTransform;

			Assert.IsNotNull(testTransform);

			Assert.AreEqual(0, testTransform.TranslateX);

			VisualStateManager.GoToState(SUT.root, "Normal", false);
			await TestServices.WindowHelper.WaitForIdle();
			Assert.AreEqual(-10, testTransform.TranslateY);

			SUT.sp01.Tag = 42;
			VisualStateManager.GoToState(SUT.root, "Focused", false);
			await TestServices.WindowHelper.WaitForIdle();
			Assert.AreEqual(42, testTransform.TranslateY);

			SUT.sp01.Tag = 43;
			VisualStateManager.GoToState(SUT.root, "Normal", false);
			await TestServices.WindowHelper.WaitForIdle();
			Assert.AreEqual(43, testTransform.TranslateY);
		}

		[TestMethod]
		[RunsOnUIThread]
#if !__CROSSRUNTIME__
		[Ignore("We override <Measure|Arrange>Override to include padding in ContentControl which is a superclass of UserControl on Uno")]
#endif
		public async Task When_Padding_Set_In_SizeChanged()
		{
			var SUT = new UserControl()
			{
				Width = 200,
				Height = 200,
				Content = new Border()
				{
					Child = new Ellipse()
					{
						Fill = new SolidColorBrush(Colors.DarkOrange)
					}
				}
			};

			SUT.SizeChanged += (sender, args) => SUT.Padding = new Thickness(0, 200, 0, 0);

			TestServices.WindowHelper.WindowContent = SUT;
			await TestServices.WindowHelper.WaitForLoaded(SUT);
			await TestServices.WindowHelper.WaitForIdle();

			// We have a problem on IOS and Android where SUT isn't relayouted after the padding
			// change even though IsMeasureDirty is true. This is a workaround to explicity relayout.
#if __IOS__ || __ANDROID__
			SUT.InvalidateMeasure();
			SUT.UpdateLayout();
#endif

			// Padding shouldn't affect measure
			Assert.AreEqual(0, ((UIElement)VisualTreeHelper.GetChild(SUT, 0)).ActualOffset.Y);
		}
	}
}
