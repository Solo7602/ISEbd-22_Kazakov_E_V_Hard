using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labaBuldozerKazakovISEbd_22
{
    public partial class ParkingPlace : Form
    {
		private readonly Parking<BuldozerBase, InterDop> parking;
		public ParkingPlace()
		{
			InitializeComponent();
			parking = new Parking<BuldozerBase, InterDop>(pictureBoxPark.Width,
pictureBoxPark.Height);
			Draw();
		}
		private void Draw()
		{
			Bitmap bmp = new Bitmap(pictureBoxPark.Width, pictureBoxPark.Height);
			Graphics gr = Graphics.FromImage(bmp);
			parking?.Draw(gr);
			pictureBoxPark.Image = bmp;
		}
        private void buttonParking_MouseClick(object sender, MouseEventArgs e)
        {
			ColorDialog dialog = new ColorDialog();
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				var buldozer = new BuldozerBase(100, 1000, dialog.Color);
				if (parking + buldozer != -1)
				{
					Draw();
				}
				else
				{
					MessageBox.Show("Парковка переполнена");
				}
			}
		}

        private void buttonModParking_MouseClick(object sender, MouseEventArgs e)
        {
			ColorDialog dialog = new ColorDialog();
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				ColorDialog dialogDop = new ColorDialog();
				if (dialogDop.ShowDialog() == DialogResult.OK)
				{
					var buldozer = new ModBuldozer(100, 1000, dialog.Color, dialogDop.Color,
				   true, true, 2, 2);
					if (parking + buldozer != -1)
					{
						Draw();
					}
					else
					{
						MessageBox.Show("Парковка переполнена");
					}
				}
			}
		}

        private void buttonOutPark_MouseClick(object sender, MouseEventArgs e)
        {
			if (maskedTextBoxNumber.Text != "")
			{
				var bulldozer = parking - Convert.ToInt32(maskedTextBoxNumber.Text);
				if (bulldozer != null)
				{
					FormBulldozer form = new FormBulldozer();
					form.SetBulldozer(bulldozer);
					form.ShowDialog();
				}
				Draw();
			}
		}
    }
}
