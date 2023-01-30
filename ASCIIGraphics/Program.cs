using System;
using System.Windows.Forms;

namespace ASCIIGraphics {
	static class Program {
		/// <summary>
		/// Главная точка входа для приложения.
		/// </summary>
		[STAThread]
		static void Main() {
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			MainForm main = new MainForm();
			Application.Run(main);
			
		}
	}
}
