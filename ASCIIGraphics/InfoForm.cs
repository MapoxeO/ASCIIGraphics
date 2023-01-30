using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ASCIIGraphics {
	public partial class InfoForm : Form {

		public enum CHOOSEN_BUTTON : byte {
			NotSelected,
			GeneralButton, ConvertingButton, SavingButton
		}
		
		public CHOOSEN_BUTTON cButton { get; private set; }
		public const string GENERAL_INFO_TEXT =
			"Простое приложение, которое создаёт изображение переводя " +
			"картинку специальным образом в набор символов, а затем показывает " +
			"получившийся текст через консоль, создавая впечталение " +
			"цельной чёрно-белой картинки.";
		public const string CONVERTING_INFO_TEXT =
			"Для того, чтобы перевести изображение в набор символов, нажмите на кнопку " +
			"\"Выбрать файл\". Выберите файл. Следует учесть, что программа работает " +
			"только с изображниями формата bmp, jpg, jpeg, png или же txt. Далее, в зависимости " +
			"от настроек размеров шрифта, форматирование картинки будет занимать " +
			"разное время. После окончания преобразования на слегка тёмном фоне " +
			"будет имя выбранного файла, а также появится кнопка \"Показать\". " +
			"После нажатия откроется консоль, где будет видна преобразованная картинка.";
		public const string SAVING_INFO_TEXT =
			"Чтобы сохранить получившийся набор символов, нужно поставить галочку " +
			"и выбрать файл. После этого программа создаст файл, который можно будет в будущем прочесть.";

		public InfoForm() {
			cButton = CHOOSEN_BUTTON.NotSelected;
			
			InitializeComponent();
		}

		private void GeneralButton_Click(object sender, EventArgs e) {
			if (cButton == CHOOSEN_BUTTON.GeneralButton) return;
			cButton = CHOOSEN_BUTTON.GeneralButton;
			this.InfoTextBox.Text = GENERAL_INFO_TEXT;
		}

		private void ConvertingButton_Click(object sender, EventArgs e) {
			if (cButton == CHOOSEN_BUTTON.ConvertingButton) return;
			cButton = CHOOSEN_BUTTON.ConvertingButton;
			this.InfoTextBox.Text = CONVERTING_INFO_TEXT;
		}

		private void SavingButton_Click(object sender, EventArgs e) {
			if (cButton == CHOOSEN_BUTTON.SavingButton) return;
			cButton = CHOOSEN_BUTTON.SavingButton;
			this.InfoTextBox.Text = SAVING_INFO_TEXT;
		}
	}
}
