
namespace ASCIIGraphics {
	partial class SettingsForm {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
			this.SizeTrackBar = new System.Windows.Forms.TrackBar();
			this.SetSizeLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.SizeTrackBar)).BeginInit();
			this.SuspendLayout();
			// 
			// SizeTrackBar
			// 
			this.SizeTrackBar.Location = new System.Drawing.Point(139, 12);
			this.SizeTrackBar.Maximum = 2;
			this.SizeTrackBar.Name = "SizeTrackBar";
			this.SizeTrackBar.Size = new System.Drawing.Size(104, 45);
			this.SizeTrackBar.TabIndex = 0;
			// 
			// SetSizeLabel
			// 
			this.SetSizeLabel.AutoSize = true;
			this.SetSizeLabel.Location = new System.Drawing.Point(12, 18);
			this.SetSizeLabel.Name = "SetSizeLabel";
			this.SetSizeLabel.Size = new System.Drawing.Size(13, 13);
			this.SetSizeLabel.TabIndex = 1;
			this.SetSizeLabel.Text = "0";
			// 
			// SettingsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(255, 66);
			this.Controls.Add(this.SetSizeLabel);
			this.Controls.Add(this.SizeTrackBar);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SettingsForm";
			this.Text = "0";
			this.Load += new System.EventHandler(this.SettingsForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.SizeTrackBar)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		internal System.Windows.Forms.TrackBar SizeTrackBar;
		internal System.Windows.Forms.Label SetSizeLabel;
	}
}