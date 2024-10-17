namespace Assignment2_study
{
	partial class ControlPanel
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnExit = new System.Windows.Forms.Button();
			this.btnPlay = new System.Windows.Forms.Button();
			this.btnDesign = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(265, 209);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(265, 84);
			this.btnExit.TabIndex = 8;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnPlay
			// 
			this.btnPlay.Location = new System.Drawing.Point(439, 88);
			this.btnPlay.Name = "btnPlay";
			this.btnPlay.Size = new System.Drawing.Size(265, 84);
			this.btnPlay.TabIndex = 7;
			this.btnPlay.Text = "Play";
			this.btnPlay.UseVisualStyleBackColor = true;
			this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
			// 
			// btnDesign
			// 
			this.btnDesign.Location = new System.Drawing.Point(91, 88);
			this.btnDesign.Name = "btnDesign";
			this.btnDesign.Size = new System.Drawing.Size(265, 84);
			this.btnDesign.TabIndex = 6;
			this.btnDesign.Text = "Design";
			this.btnDesign.UseVisualStyleBackColor = true;
			this.btnDesign.Click += new System.EventHandler(this.btnDesign_Click);
			// 
			// ControlPanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 374);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnPlay);
			this.Controls.Add(this.btnDesign);
			this.Name = "ControlPanel";
			this.Text = "Control Panel";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnPlay;
		private System.Windows.Forms.Button btnDesign;
	}
}

