#nullable enable

using System;
using System.Numerics;
using SkiaSharp;
using Windows.Foundation;
using Uno.UI;

namespace Windows.UI.Composition
{
	public partial class CompositionSurfaceBrush : CompositionBrush
	{
		internal override void UpdatePaint(SKPaint fillPaint, SKRect bounds)
		{
			if (Surface is SkiaCompositionSurface scs && scs.Image is { } image)
			{
				var stretchMatrix = GetStretchedSizeTransform(new SKSize(image.Width, image.Height), bounds.Size);

				var imageShader = SKShader.CreateImage(
					scs.Image,
					SKShaderTileMode.Clamp,
					SKShaderTileMode.Clamp,
					TransformMatrix.ToSKMatrix().PostConcat(stretchMatrix));

				fillPaint.Shader = imageShader;

				fillPaint.IsAntialias = true;
			}
			else
			{
				fillPaint.Shader = null;
			}
		}

		private SKMatrix GetStretchedSizeTransform(SKSize sourceSize, SKSize targetSize)
		{
			var sourceAspectRatio = GetAspectRatio(sourceSize);
			var targetAspectRatio = GetAspectRatio(targetSize);

			var actualTargetSize = Stretch switch
			{
				CompositionStretch.None => sourceSize,
				CompositionStretch.Fill => targetSize,
				CompositionStretch.Uniform =>
					targetAspectRatio > sourceAspectRatio
						? new SKSize(sourceSize.Width * targetSize.Height / sourceSize.Height, targetSize.Height)
						: new SKSize(targetSize.Width, sourceSize.Height * targetSize.Width / sourceSize.Width),
				CompositionStretch.UniformToFill =>
						targetAspectRatio < sourceAspectRatio
							? new SKSize(sourceSize.Width * targetSize.Height / sourceSize.Height, targetSize.Height)
							: new SKSize(targetSize.Width, sourceSize.Height * targetSize.Width / sourceSize.Width),
				_ => throw new InvalidOperationException("Unsupported stretch value")
			};

			return SKMatrix.CreateScale(actualTargetSize.Width / sourceSize.Width, actualTargetSize.Height / sourceSize.Height);
		}

		private static double GetAspectRatio(SKSize size)
		{
			var w = size.Width;
			var h = size.Height;

			switch (w)
			{
				case float.NegativeInfinity:
					return -1;
				case float.PositiveInfinity:
					return 1;
				case float.NaN:
					return 1;
				case 0.0f:
					return 1;
			}

			switch (h)
			{
				case float.NegativeInfinity:
					return -1;
				case float.PositiveInfinity:
					return 1;
				case float.NaN:
					return 1;
				case 0.0f:
					return 1; // special case
				case 1.0f:
					return w;
			}

			return w / h;
		}
	}
}
