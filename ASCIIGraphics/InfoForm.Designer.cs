
namespace ASCIIGraphics {
	partial class InfoForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoForm));
			this.GeneralButton = new System.Windows.Forms.Button();
			this.ConvertingButton = new System.Windows.Forms.Button();
			this.SavingButton = new System.Windows.Forms.Button();
			this.InfoTextBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// GeneralButton
			// 
			this.GeneralButton.Location = new System.Drawing.Point(12, 30);
			this.GeneralButton.Name = "GeneralButton";
			this.GeneralButton.Size = new System.Drawing.Size(95, 23);
			this.GeneralButton.TabIndex = 0;
			this.GeneralButton.Text = "Общее";
			this.GeneralButton.UseVisualStyleBackColor = true;
			this.GeneralButton.Click += new System.EventHandler(this.GeneralButton_Click);
			// 
			// ConvertingButton
			// 
			this.ConvertingButton.Location = new System.Drawing.Point(12, 59);
			this.ConvertingButton.Name = "ConvertingButton";
			this.ConvertingButton.Size = new System.Drawing.Size(95, 23);
			this.ConvertingButton.TabIndex = 1;
			this.ConvertingButton.Text = "Конвертация";
			this.ConvertingButton.UseVisualStyleBackColor = true;
			this.ConvertingButton.Click += new System.EventHandler(this.ConvertingButton_Click);
			// 
			// SavingButton
			// 
			this.SavingButton.Enabled = false;
			this.SavingButton.Location = new System.Drawing.Point(330, 82);
			this.SavingButton.Name = "SavingButton";
			this.SavingButton.Size = new System.Drawing.Size(95, 23);
			this.SavingButton.TabIndex = 2;
			this.SavingButton.Text = "Сохранение";
			this.SavingButton.UseVisualStyleBackColor = true;
			this.SavingButton.Visible = false;
			this.SavingButton.Click += new System.EventHandler(this.SavingButton_Click);
			// 
			// InfoTextBox
			// 
			this.InfoTextBox.Location = new System.Drawing.Point(113, 12);
			this.InfoTextBox.Multiline = true;
			this.InfoTextBox.Name = "InfoTextBox";
			this.InfoTextBox.ReadOnly = true;
			this.InfoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.InfoTextBox.Size = new System.Drawing.Size(295, 82);
			this.InfoTextBox.TabIndex = 3;
			// 
			// InfoForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(420, 106);
			this.Controls.Add(this.InfoTextBox);
			this.Controls.Add(this.SavingButton);
			this.Controls.Add(this.ConvertingButton);
			this.Controls.Add(this.GeneralButton);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "InfoForm";
			this.Text = "Справка";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button GeneralButton;
		private System.Windows.Forms.Button ConvertingButton;
		private System.Windows.Forms.Button SavingButton;
		private System.Windows.Forms.TextBox InfoTextBox;
	}
}