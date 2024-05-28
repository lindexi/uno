using System;
using System.Diagnostics;
using System.IO;

using Microsoft.UI.Xaml;
using SkiaSharp;
using Uno.Foundation.Logging;
using Uno.UI.Hosting;

namespace Uno.WinUI.Runtime.Skia.X11
{
	internal class X11SoftwareRenderer(IXamlRootHost host, X11Window x11window) : IX11Renderer
	{
		private const int ColorDepth = 32;
		private const int BitmapPad = 32;

		private SKBitmap? _bitmap;
		private SKSurface? _surface;
		private XImage? _xImage;
		private int renderCount;

		private IntPtr? _gc;

		void IX11Renderer.InvalidateRender()
		{
			using var _1 = X11Helper.XLock(x11window.Display);

			if (host is X11XamlRootHost { Closed.IsCompleted: true })
			{
				return;
			}

			if (renderCount == 0)
			{
				//Console.WriteLine($"First render {Stopwatch.GetTimestamp()}");
			}

			if (this.Log().IsEnabled(LogLevel.Trace))
			{
				this.Log().Trace($"Render {renderCount++}");
			}

			XWindowAttributes attributes = default;
			var _2 = XLib.XGetWindowAttributes(x11window.Display, x11window.Window, ref attributes);

			var width = attributes.width;
			var height = attributes.height;

			// TODO: make sure this works everywhere. AFAICT everyone is using 24 bit color with 32 bit_pad
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
				canvas.Clear(SKColors.Transparent);
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
				const int bytePerPixelCount = 4; // RGBA 一共4个 byte 长度
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
				img.bitmap_pad = bitsPerPixel;
				img.depth = bitsPerPixel;
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

			//// 尝试输出渲染的图
			//var fileName = $"x{renderCount}.png";
			renderCount++;
			//using (var skData = _bitmap.Encode(SKEncodedImageFormat.Png, 100))
			//{
			//	var file = new FileInfo(fileName);
			//	using (var fileStream = file.OpenWrite())
			//	{
			//		fileStream.SetLength(0);
			//		skData.SaveTo(fileStream);
			//	}
			//}
		}
	}
}
