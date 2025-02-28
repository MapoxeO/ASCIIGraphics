﻿using System.Drawing;

namespace ASCIIGraphics {
	public static class Extensions {
		public static void ToGrayScale(this Bitmap bitmap) {
			for (int y = 0; y < bitmap.Height; y++) {
				for (int x = 0; x < bitmap.Width; x++) {
					var pixel = bitmap.GetPixel(x, y);
					int avg = (pixel.R + pixel.G + pixel.B) / 3;
					bitmap.SetPixel(x, y, Color.FromArgb(pixel.A, avg, avg, avg));
				}
			}
		}

		public static int IndexOf(this char[] s, char a) {
			for (int i = 0; i < s.Length; ++i) if (s[i] == a) return i; return -1;
		}
	}
}
