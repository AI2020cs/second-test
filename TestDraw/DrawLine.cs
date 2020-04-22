using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestDraw
{
	public partial class DrawLine : Form
	{
		public DrawLine()
		{
			InitializeComponent();
		}

		private void btnDrawLine_Click(object sender, EventArgs e)
		{
			Point p1 = new Point(50, 60);
			Point p2 = new Point(300, 60);
			this.CreateGraphics().DrawLine(Pens.Red, p1, p2);
		}
	}
}
