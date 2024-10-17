/*
 * Black Hole Game
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2_study
{
	public partial class ControlPanel : Form
	{
		public ControlPanel()
		{
			InitializeComponent();
		}

		private void btnDesign_Click(object sender, EventArgs e)
		{
			// Creates a new form of designer type
			DesignerForm designerForm = new DesignerForm();
			designerForm.Show(); // display form
		}

		private void btnPlay_Click(object sender, EventArgs e)
		{
			// To be coded in the "Play" version of the program -- this is the "Design" version
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Dispose(); // closes all forms
		}
	}
}
