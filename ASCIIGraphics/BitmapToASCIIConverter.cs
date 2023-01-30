using System.Drawing;

namespace ASCIIGraphics {

	public class BitmapToASCIIConverter {
		//"^`'.
		private static readonly char[] _asciiTable =			{ ' ', '.', '`', '^', '"', ',', ':', '+', '*', '?', '%', 'S', '#', '@' };
		//private readonly char[] _asciiTable = " .'`^\",:;Il!i><~+_-?][}{1)(|\\/tfjrxnuvczXYUJCLQ0OZmwqpdbkhao*#MW&8%B@$".ToCharArray();
		private static readonly char[] _asciiTableNegative =	{ '@', '#', 'S', '%', '?', '*', '+', ':', ',', '^', '"', '`', '.', ' ' };

		private readonly Bitmap _bitmap;

		public BitmapToASCIIConverter(Bitmap bitmap) { _bitmap = bitmap; }

		public char[][] Convert() { return Convert(_asciiTable);  }

		public char[][] ConvertAsNegative() { return Convert(_asciiTableNegative); }

		public static char[] NegateTable(in string str) {
			var __out = str.ToCharArray();
			for (int i = 0; i < __out.Length; ++i) {
				__out[i] = _asciiTableNegative[
					_asciiTableNegative.Length - _asciiTable.IndexOf(__out[i])
					];
			}
			return __out;
		}

		private char[][] Convert(char[] asciiTable) {
			var result = new char[_bitmap.Height][];

			for (int y = 0; y < _bitmap.Height; y++) {
				result[y] = new char[_bitmap.Width];

				for (int x = 0; x < _bitmap.Width; x++) {
					int mapIndex = (int)Clamp(_bitmap.GetPixel(x, y).R, 0, 255, 0, asciiTable.Length - 1);
					result[y][x] = asciiTable[mapIndex];
				}
			}

			return result;
		}


		private float Clamp(float valueToMap, float start1, float stop1, float start2, float stop2) {
			return ((valueToMap - start1) / (stop1 - start1)) * (stop2 - start2) + start2;
		}

	}
}
