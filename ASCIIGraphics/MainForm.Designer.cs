
namespace ASCIIGraphics {
	partial class MainForm {
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.SavePictureCheckBox = new System.Windows.Forms.CheckBox();
			this.ChooseFileButton = new System.Windows.Forms.Button();
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.InfoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.SettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ShowPicButton = new System.Windows.Forms.Button();
			this.ChoosenFileNameLabel = new System.Windows.Forms.Label();
			this.menuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// SavePictureCheckBox
			// 
			this.SavePictureCheckBox.AutoSize = true;
			this.SavePictureCheckBox.Enabled = false;
			this.SavePictureCheckBox.Location = new System.Drawing.Point(129, 61);
			this.SavePictureCheckBox.Name = "SavePictureCheckBox";
			this.SavePictureCheckBox.Size = new System.Drawing.Size(134, 17);
			this.SavePictureCheckBox.TabIndex = 0;
			this.SavePictureCheckBox.Text = "Сохранить картинку?";
			this.SavePictureCheckBox.UseVisualStyleBackColor = true;
			this.SavePictureCheckBox.Visible = false;
			this.SavePictureCheckBox.CheckedChanged += new System.EventHandler(this.SavePictureCheckBox_CheckedChanged);
			// 
			// ChooseFileButton
			// 
			this.ChooseFileButton.Location = new System.Drawing.Point(12, 55);
			this.ChooseFileButton.Name = "ChooseFileButton";
			this.ChooseFileButton.Size = new System.Drawing.Size(111, 23);
			this.ChooseFileButton.TabIndex = 1;
			this.ChooseFileButton.Text = "Выбрать файл";
			this.ChooseFileButton.UseVisualStyleBackColor = true;
			this.ChooseFileButton.Click += new System.EventHandler(this.ChooseFileButton_Click);
			// 
			// menuStrip
			// 
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InfoMenuItem,
            this.SettingsToolStripMenuItem});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(270, 24);
			this.menuStrip.TabIndex = 2;
			this.menuStrip.Text = "menuStrip1";
			// 
			// InfoMenuItem
			// 
			this.InfoMenuItem.BackColor = System.Drawing.SystemColors.Control;
			this.InfoMenuItem.Name = "InfoMenuItem";
			this.InfoMenuItem.Size = new System.Drawing.Size(69, 20);
			this.InfoMenuItem.Text = "Справка";
			this.InfoMenuItem.Click += new System.EventHandler(this.InfoMenuItem_Click);
			// 
			// SettingsToolStripMenuItem
			// 
			this.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem";
			this.SettingsToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
			this.SettingsToolStripMenuItem.Text = "Настройки";
			this.SettingsToolStripMenuItem.Click += new System.EventHandler(this.SettingsToolStripMenuItem_Click);
			// 
			// ShowPicButton
			// 
			this.ShowPicButton.Cursor = System.Windows.Forms.Cursors.Default;
			this.ShowPicButton.Enabled = false;
			this.ShowPicButton.Location = new System.Drawing.Point(31, 84);
			this.ShowPicButton.Name = "ShowPicButton";
			this.ShowPicButton.Size = new System.Drawing.Size(75, 23);
			this.ShowPicButton.TabIndex = 3;
			this.ShowPicButton.Text = "Показать";
			this.ShowPicButton.UseVisualStyleBackColor = true;
			this.ShowPicButton.Visible = false;
			this.ShowPicButton.Click += new System.EventHandler(this.ShowPicButton_Click);
			// 
			// ChoosenFileNameLabel
			// 
			this.ChoosenFileNameLabel.AutoSize = true;
			this.ChoosenFileNameLabel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.ChoosenFileNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ChoosenFileNameLabel.ForeColor = System.Drawing.SystemColors.ControlText;
			this.ChoosenFileNameLabel.Location = new System.Drawing.Point(20, 30);
			this.ChoosenFileNameLabel.Name = "ChoosenFileNameLabel";
			this.ChoosenFileNameLabel.Size = new System.Drawing.Size(2, 15);
			this.ChoosenFileNameLabel.TabIndex = 4;
			this.ChoosenFileNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.ChoosenFileNameLabel.Visible = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(270, 128);
			this.Controls.Add(this.ChoosenFileNameLabel);
			this.Controls.Add(this.ShowPicButton);
			this.Controls.Add(this.ChooseFileButton);
			this.Controls.Add(this.SavePictureCheckBox);
			this.Controls.Add(this.menuStrip);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.Text = "ASCII Images";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckBox SavePictureCheckBox;
		private System.Windows.Forms.Button ChooseFileButton;
		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem InfoMenuItem;
		private System.Windows.Forms.Button ShowPicButton;
		private System.Windows.Forms.Label ChoosenFileNameLabel;
		private System.Windows.Forms.ToolStripMenuItem SettingsToolStripMenuItem;
	}
}

