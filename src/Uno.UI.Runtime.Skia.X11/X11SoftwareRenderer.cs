using System;
using Microsoft.UI.Xaml;
using SkiaSharp;
using Uno.Foundation.Logging;
using Uno.UI.Hosting;

namespace Uno.WinUI.Runtime.Skia.X11
{
	internal class X11SoftwareRenderer(IXamlRootHost host, X11Window x11window, uint colorDepth) : IX11Renderer
	{
		private const int BitmapPad = 32;

		private SKBitmap? _bitmap;
		private SKSurface? _surface;
		private XImage? _xImage;
		private int _renderCount;
		private IntPtr? _gc;
		public SKColor BackgroundColor { get; set; } = SKColors.White;

		void IX11Renderer.InvalidateRender()
		{
			using var _1 = X11Helper.XLock(x11window.Display);

			if (host is X11XamlRootHost { Closed.IsCompleted: true })
			{
				return;
			}

			if (this.Log().IsEnabled(LogLevel.Trace))
			{
				this.Log().Trace($"Render {_renderCount++}");
			}

			XWindowAttributes attributes = default;
			var _2 = XLib.XGetWindowAttributes(x11window.Display, x11window.Window, ref attributes);

			var width = attributes.width;
			var height = attributes.height;

			// endianness might come into play here?
			var info = new SKImageInfo(width, height, SKColorType.Bgra8888, SKAlphaType.Premul);

			// reset the bitmap if the size has changed
			if (_bitmap == null || _surface == null || info.Width != _bitmap.Width || info.Height != _bitmap.Height)
			{
				_bitmap?.Dispose();
				_surface?.Dispose();

				if (_xImage is { } xImage)
				{
					unsafe
					{
						// XDestroyImage frees the buffer as well, so we unset it first
						ref var ptr = ref xImage;
						ptr.data = IntPtr.Zero;
						var _3 = XLib.XDestroyImage(new IntPtr(&xImage));
					}
					_xImage = null;
				}

				_bitmap = new SKBitmap(width, height);
				_surface = SKSurface.Create(info, _bitmap.GetPixels(out _));
			}

			var canvas = _surface.Canvas;
			using (new SKAutoCanvasRestore(canvas, true))
			{
				canvas.Clear(BackgroundColor);
				var scale = host.RootElement?.XamlRoot is { } root
					? root.RasterizationScale
					: 1;
				canvas.Scale((int)scale);

				if (host.RootElement?.Visual is { } rootVisual)
				{
					host.RootElement.XamlRoot!.Compositor.RenderRootVisual(_surface, rootVisual);
				}

				canvas.Flush();
			}

			if (_xImage is null)
			{
				const int bytePerPixelCount = 4; // RGBA
				var bitPerByte = 8;

				var bitmapWidth = width;
				var bitmapHeight = height;

				var img = new XImage();
				int bitsPerPixel = bytePerPixelCount * bitPerByte;
				img.width = bitmapWidth;
				img.height = bitmapHeight;
				img.format = 2; //ZPixmap;
				img.data = _bitmap.GetPixels();
				img.byte_order = 0; // LSBFirst;
				img.bitmap_unit = bitsPerPixel;
				img.bitmap_bit_order = 0; // LSBFirst;
				img.bitmap_pad = BitmapPad;
				img.depth = (int)colorDepth;
				img.bytes_per_line = bitmapWidth * bytePerPixelCount;
				img.bits_per_pixel = bitsPerPixel;
				_ = X11Helper.XInitImage(ref img);

				_xImage = img;
			}

			var image = _xImage.Value;

			_gc ??= X11Helper.XCreateGC(x11window.Display, x11window.Window, 0, 0);
			var gc = _gc.Value;

			var _4 = X11Helper.XPutImage(
				display: x11window.Display,
				drawable: x11window.Window,
				gc: gc,
				image: ref image,
				srcx: 0,
				srcy: 0,
				destx: 0,
				desty: 0,
				width: (uint)width,
				height: (uint)height);

			var _5 = XLib.XFlush(x11window.Display); // unnecessary on most X11 implementations
		}
	}
}
