// Imports
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2_study
{
	/// <summary>
	/// Represents a Square in the "Black Hole" or "QGame" grid (a subclass of PictureBox)
	/// </summary>
	public class Square : PictureBox
	{
		public static string sPattern; // static pattern in square
		private DesignerForm designerForm; // variable to represent the designer form

		/// <summary>
		/// Constructor that takes the designer form as parameter
		/// </summary>
		/// <param name="designerForm"></param>
		public Square(DesignerForm designerForm)
		{
			this.designerForm = designerForm;
			this.BorderStyle = BorderStyle.FixedSingle; // add a border to each picturebox
			this.SizeMode = PictureBoxSizeMode.StretchImage; // sets image size mode
		}
	}
}
