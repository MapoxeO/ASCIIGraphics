using System;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace ASCIIGraphics {
	public partial class MainForm : Form {

		#region DLL_IMPORT

		private const int LF_FACESIZE = 32;
		private static int STD_OUT_HANDLE = -11;

		public static IntPtr CHANDLE;
		public static IntPtr HWND;

		[StructLayout(LayoutKind.Sequential)]
		internal struct COORD {
			internal short X;
			internal short Y;
			internal COORD(short x, short y) { X = x; Y = y; }
		}

		[StructLayout(LayoutKind.Sequential)]
		internal unsafe struct CONSOLE_FONT_INFO_EX {
			internal uint cbSize;
			internal uint nFont;
			internal COORD dwFontSize;
			internal int FontFamily;
			internal int FontWeight;
			internal fixed ushort FaceName[LF_FACESIZE];
		}

		[DllImport("kernel32.dll")]
		private static extern IntPtr GetConsoleWindow();
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern IntPtr GetStdHandle(int nStdHandle);
		[DllImport("kernel32.dll")]
		private static extern bool AllocConsole();
		[DllImport("user32.dll")]
		public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
		[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
		static extern bool GetCurrentConsoleFontEx(
			   IntPtr consoleOutput,
			   bool maximumWindow,
			   ref CONSOLE_FONT_INFO_EX lpConsoleCurrentFontEx);
		[DllImport("kernel32.dll", SetLastError = true)]
		static extern bool SetCurrentConsoleFontEx(
			   IntPtr consoleOutput,
			   bool maximumWindow,
			   ref CONSOLE_FONT_INFO_EX consoleCurrentFontEx);
		[DllImport("kernel32.dll")]
		static extern bool SetConsoleTitle(string lpConsoleTitle);
		[DllImport("kernel32.dll")]
		static extern int GetLastError();

		#endregion


		public const int SW_HIDE = 0;
		public const int SW_SHOW = 5;
		public static double WIDTH_OFFSET = 2;
		public static int MAX_WIDTH = 474;
		private char[][] ASCII_Image = null;
		private static readonly COORD[] SIZES = { new COORD(1, 2), new COORD(2, 4), new COORD(3, 5) };
		private static int FONT_SIZE;

		public const string FONT_NAME = "Lucida Console";
		public const string ERROR_STR = "Ошибка";
		public const string SAVE_DIRECTORY_NAME_STR = "Images";
		public const string FILE_CHOOSEN_STR = "Файл";
		public const string INFO_BAR_STR = "Справка";

		private SettingsForm SettingsForm;
		private InfoForm InfoForm;
//		private readonly OpenFileDialog openFileDialog = new OpenFileDialog { Filter = "Images | *.bmp; *.png; *.jpg; *.jpeg | Text | *.txt" };
		private readonly OpenFileDialog openFileDialog = new OpenFileDialog { Filter = "Images | *.bmp; *.png; *.jpg; *.jpeg" };

		private static Bitmap ResizeBitmap(Bitmap bitmap) {
			var newHeight = bitmap.Height / WIDTH_OFFSET * MAX_WIDTH / bitmap.Width;
			if (bitmap.Width > MAX_WIDTH || bitmap.Height > newHeight)
				bitmap = new Bitmap(bitmap, new Size(MAX_WIDTH, (int)newHeight));
			return bitmap;
		}

		public unsafe MainForm() { 
			InitializeComponent();
			SettingsForm = new SettingsForm();
			InfoForm = new InfoForm();

			SettingsForm.FormClosing += SettingsForm_Exit;
			SettingsForm.Text = "Настройки";
			SettingsForm.SetSizeLabel.Text = "Размер шрифта консоли";

			InfoForm.Text = "Справка";
		}

		public void SettingsForm_Exit(object sender, EventArgs e) {
			SetNewSize(SettingsForm.SizeTrackBar.Value);
		}

		private static unsafe void SetNewFont(string fontName, COORD fontSize) {
			var newFont = new CONSOLE_FONT_INFO_EX { cbSize = (uint)sizeof(CONSOLE_FONT_INFO_EX) };
			var oldFont = new CONSOLE_FONT_INFO_EX { cbSize = (uint)sizeof(CONSOLE_FONT_INFO_EX) };

			GetCurrentConsoleFontEx(HWND, false, ref oldFont);
			newFont.dwFontSize = fontSize;
			newFont.FontFamily = oldFont.FontFamily;
			newFont.FontWeight = oldFont.FontWeight;
			Marshal.Copy(fontName.ToCharArray(), 0, new IntPtr(newFont.FaceName), fontName.Length);
			newFont.cbSize = (uint)Marshal.SizeOf(newFont);
			SetCurrentConsoleFontEx(HWND, false, ref newFont);
		}

		private static unsafe void SetNewSize(int size) {
			FONT_SIZE = size;
			SetNewFont(FONT_NAME, SIZES[FONT_SIZE]);
			WIDTH_OFFSET = (double)SIZES[FONT_SIZE].Y / SIZES[FONT_SIZE].X;
			try {
				Console.SetBufferSize(Console.LargestWindowWidth, 3 * Console.LargestWindowHeight);
				Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight - 8);
				MAX_WIDTH = Console.LargestWindowWidth * 3 / 4;
			} catch (Exception e) {
				if (MessageBox.Show(e.Message, ERROR_STR, icon: MessageBoxIcon.Hand, buttons: MessageBoxButtons.OK) != DialogResult.None) {
					Application.Exit();
					Environment.Exit(-1);
				}
			}
		}

		private void MainForm_Load(object sender, EventArgs e) {
			AllocConsole();

			CHANDLE = GetConsoleWindow();
			HWND = GetStdHandle(STD_OUT_HANDLE);
			SetNewSize(1);

			Console.BackgroundColor = ConsoleColor.Black;
			Console.ForegroundColor = ConsoleColor.White;
			SetConsoleTitle("Picture viewing");
			Console.CursorVisible = false;
			ShowWindow(CHANDLE, SW_HIDE);
		}
		private static int Min(int x, int y) { return (x < y) ? x : y; }

		private static string GetExtension(in string s) { return s.Substring(s.Length - 4, 4); }

		private void ChooseFileButton_Click(object sender, EventArgs e) {
			if (openFileDialog.ShowDialog() != DialogResult.OK) return;

			/*
			if (GetExtension(openFileDialog.SafeFileName) == ".txt") {
				var strings = new List<char[]>(from s in File.ReadAllLines(openFileDialog.FileName)
											   select BitmapToASCIIConverter.NegateTable(s.Substring(0, s.Length - 1)));
				ASCII_Image = new char[strings.Count][];
				for (int i = 0; i < strings.Count; ++i) {
					ASCII_Image[i] = strings[i];
				}
			} else {*/
				var bitMap = new Bitmap(openFileDialog.FileName);
				bitMap = ResizeBitmap(bitMap);
				bitMap.ToGrayScale();
				var converter = new BitmapToASCIIConverter(bitMap);
				ASCII_Image = converter.Convert();

				if (this.SavePictureCheckBox.Checked == true) {
					try {
						var ASCII_Image_NEG = converter.ConvertAsNegative();
						File.WriteAllLines($"{SAVE_DIRECTORY_NAME_STR}\\{openFileDialog.SafeFileName}.txt", ASCII_Image_NEG.Select(r => new string(r)));
					} catch (Exception ex) {
						_ = MessageBox.Show(text: ex.Message, caption: ERROR_STR, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Hand);
					}
				}
			//}

			this.ShowPicButton.Enabled = true;
			this.ShowPicButton.Visible = true;
			this.ChoosenFileNameLabel.Text = $"{FILE_CHOOSEN_STR}: {openFileDialog.SafeFileName}";
			this.ChoosenFileNameLabel.Visible = true;
		}
		
		private void InfoMenuItem_Click(object sender, EventArgs e) {
			/// TODO: Make Info Panel.
			InfoForm.ShowDialog();
			//_ = MessageBox.Show(INFO_STR, INFO_BAR_STR, MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
		
		private void ShowPicButton_Click(object sender, EventArgs e) {
			Console.Clear();
			/*			TODO: Resize console before screening image.
 			try {
				Console.SetWindowSize(1, 1);
				Console.SetBufferSize(ASCII_Image[0].Length, ASCII_Image.Length);
				Console.SetWindowSize(Min(ASCII_Image[0].Length, Console.LargestWindowWidth), Min(ASCII_Image.Length, Console.LargestWindowHeight));
			}*/

			ShowWindow(CHANDLE, SW_SHOW);
			foreach (var row in ASCII_Image)
				Console.WriteLine(row);
			Console.SetCursorPosition(0, 0);
			Console.ReadKey();
			ShowWindow(CHANDLE, SW_HIDE);
		}

		private void SavePictureCheckBox_CheckedChanged(object sender, EventArgs e) {
			if (!Directory.Exists(SAVE_DIRECTORY_NAME_STR)) {
				Directory.CreateDirectory(SAVE_DIRECTORY_NAME_STR);
			}
		}

		private void SettingsToolStripMenuItem_Click(object sender, EventArgs e) {
			SettingsForm.ShowDialog();
		}
	}
}
