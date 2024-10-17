namespace Assignment2_study
{
	partial class DesignerForm
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
			this.menuStripGameMenu = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnGenerate = new System.Windows.Forms.Button();
			this.txtColumns = new System.Windows.Forms.TextBox();
			this.txtRows = new System.Windows.Forms.TextBox();
			this.lblColumns = new System.Windows.Forms.Label();
			this.lblRows = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnGreenBox = new System.Windows.Forms.Button();
			this.btnRedBox = new System.Windows.Forms.Button();
			this.btnGreenDoor = new System.Windows.Forms.Button();
			this.btnRedDoor = new System.Windows.Forms.Button();
			this.btnWall = new System.Windows.Forms.Button();
			this.btnNone = new System.Windows.Forms.Button();
			this.lblToolbox = new System.Windows.Forms.Label();
			this.menuStripGameMenu.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStripGameMenu
			// 
			this.menuStripGameMenu.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
			this.menuStripGameMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.menuStripGameMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
			this.menuStripGameMenu.Location = new System.Drawing.Point(0, 0);
			this.menuStripGameMenu.Name = "menuStripGameMenu";
			this.menuStripGameMenu.Size = new System.Drawing.Size(1186, 33);
			this.menuStripGameMenu.TabIndex = 0;
			this.menuStripGameMenu.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.closeToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(157, 34);
			this.saveToolStripMenuItem.Text = "&Save";
			// 
			// closeToolStripMenuItem
			// 
			this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
			this.closeToolStripMenuItem.Size = new System.Drawing.Size(157, 34);
			this.closeToolStripMenuItem.Text = "&Close";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnGenerate);
			this.panel1.Controls.Add(this.txtColumns);
			this.panel1.Controls.Add(this.txtRows);
			this.panel1.Controls.Add(this.lblColumns);
			this.panel1.Controls.Add(this.lblRows);
			this.panel1.Location = new System.Drawing.Point(0, 36);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1188, 86);
			this.panel1.TabIndex = 1;
			// 
			// btnGenerate
			// 
			this.btnGenerate.Location = new System.Drawing.Point(526, 21);
			this.btnGenerate.Name = "btnGenerate";
			this.btnGenerate.Size = new System.Drawing.Size(207, 45);
			this.btnGenerate.TabIndex = 9;
			this.btnGenerate.Text = "Generate";
			this.btnGenerate.UseVisualStyleBackColor = true;
			// 
			// txtColumns
			// 
			this.txtColumns.Location = new System.Drawing.Point(358, 31);
			this.txtColumns.Name = "txtColumns";
			this.txtColumns.Size = new System.Drawing.Size(115, 26);
			this.txtColumns.TabIndex = 8;
			this.txtColumns.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// txtRows
			// 
			this.txtRows.Location = new System.Drawing.Point(122, 31);
			this.txtRows.Name = "txtRows";
			this.txtRows.Size = new System.Drawing.Size(115, 26);
			this.txtRows.TabIndex = 7;
			this.txtRows.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// lblColumns
			// 
			this.lblColumns.AutoSize = true;
			this.lblColumns.Location = new System.Drawing.Point(276, 34);
			this.lblColumns.Name = "lblColumns";
			this.lblColumns.Size = new System.Drawing.Size(75, 20);
			this.lblColumns.TabIndex = 6;
			this.lblColumns.Text = "Columns:";
			// 
			// lblRows
			// 
			this.lblRows.AutoSize = true;
			this.lblRows.Location = new System.Drawing.Point(64, 34);
			this.lblRows.Name = "lblRows";
			this.lblRows.Size = new System.Drawing.Size(53, 20);
			this.lblRows.TabIndex = 5;
			this.lblRows.Text = "Rows:";
			// 
			// panel2
			// 
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel2.Controls.Add(this.btnGreenBox);
			this.panel2.Controls.Add(this.btnRedBox);
			this.panel2.Controls.Add(this.btnGreenDoor);
			this.panel2.Controls.Add(this.btnRedDoor);
			this.panel2.Controls.Add(this.btnWall);
			this.panel2.Controls.Add(this.btnNone);
			this.panel2.Controls.Add(this.lblToolbox);
			this.panel2.Location = new System.Drawing.Point(0, 124);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(256, 809);
			this.panel2.TabIndex = 2;
			// 
			// btnGreenBox
			// 
			this.btnGreenBox.Image = global::Assignment2_study.Properties.Resources.green_box;
			this.btnGreenBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnGreenBox.Location = new System.Drawing.Point(20, 560);
			this.btnGreenBox.Name = "btnGreenBox";
			this.btnGreenBox.Size = new System.Drawing.Size(198, 91);
			this.btnGreenBox.TabIndex = 7;
			this.btnGreenBox.Text = "Green Box";
			this.btnGreenBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnGreenBox.UseVisualStyleBackColor = true;
			// 
			// btnRedBox
			// 
			this.btnRedBox.Image = global::Assignment2_study.Properties.Resources.red_box;
			this.btnRedBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnRedBox.Location = new System.Drawing.Point(20, 463);
			this.btnRedBox.Name = "btnRedBox";
			this.btnRedBox.Size = new System.Drawing.Size(198, 91);
			this.btnRedBox.TabIndex = 6;
			this.btnRedBox.Text = "Red Box";
			this.btnRedBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnRedBox.UseVisualStyleBackColor = true;
			// 
			// btnGreenDoor
			// 
			this.btnGreenDoor.Image = global::Assignment2_study.Properties.Resources.green_door;
			this.btnGreenDoor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnGreenDoor.Location = new System.Drawing.Point(20, 366);
			this.btnGreenDoor.Name = "btnGreenDoor";
			this.btnGreenDoor.Size = new System.Drawing.Size(198, 91);
			this.btnGreenDoor.TabIndex = 5;
			this.btnGreenDoor.Text = "Green Door";
			this.btnGreenDoor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnGreenDoor.UseVisualStyleBackColor = true;
			// 
			// btnRedDoor
			// 
			this.btnRedDoor.Image = global::Assignment2_study.Properties.Resources.red_door;
			this.btnRedDoor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnRedDoor.Location = new System.Drawing.Point(20, 269);
			this.btnRedDoor.Name = "btnRedDoor";
			this.btnRedDoor.Size = new System.Drawing.Size(198, 91);
			this.btnRedDoor.TabIndex = 4;
			this.btnRedDoor.Text = "Red Door";
			this.btnRedDoor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnRedDoor.UseVisualStyleBackColor = true;
			// 
			// btnWall
			// 
			this.btnWall.Image = global::Assignment2_study.Properties.Resources.wall;
			this.btnWall.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnWall.Location = new System.Drawing.Point(20, 172);
			this.btnWall.Name = "btnWall";
			this.btnWall.Size = new System.Drawing.Size(198, 91);
			this.btnWall.TabIndex = 3;
			this.btnWall.Text = "Wall";
			this.btnWall.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnWall.UseVisualStyleBackColor = true;
			// 
			// btnNone
			// 
			this.btnNone.Image = global::Assignment2_study.Properties.Resources.none;
			this.btnNone.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnNone.Location = new System.Drawing.Point(20, 75);
			this.btnNone.Name = "btnNone";
			this.btnNone.Size = new System.Drawing.Size(198, 91);
			this.btnNone.TabIndex = 2;
			this.btnNone.Text = "None";
			this.btnNone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnNone.UseVisualStyleBackColor = true;
			// 
			// lblToolbox
			// 
			this.lblToolbox.AutoSize = true;
			this.lblToolbox.Location = new System.Drawing.Point(85, 16);
			this.lblToolbox.Name = "lblToolbox";
			this.lblToolbox.Size = new System.Drawing.Size(64, 20);
			this.lblToolbox.TabIndex = 1;
			this.lblToolbox.Text = "Toolbox";
			// 
			// DesignerForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1186, 931);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.menuStripGameMenu);
			this.MainMenuStrip = this.menuStripGameMenu;
			this.Name = "DesignerForm";
			this.Text = "Designer Form";
			this.menuStripGameMenu.ResumeLayout(false);
			this.menuStripGameMenu.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStripGameMenu;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnGenerate;
		private System.Windows.Forms.TextBox txtColumns;
		private System.Windows.Forms.TextBox txtRows;
		private System.Windows.Forms.Label lblColumns;
		private System.Windows.Forms.Label lblRows;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label lblToolbox;
		private System.Windows.Forms.Button btnNone;
		private System.Windows.Forms.Button btnGreenBox;
		private System.Windows.Forms.Button btnRedBox;
		private System.Windows.Forms.Button btnGreenDoor;
		private System.Windows.Forms.Button btnRedDoor;
		private System.Windows.Forms.Button btnWall;
	}
}