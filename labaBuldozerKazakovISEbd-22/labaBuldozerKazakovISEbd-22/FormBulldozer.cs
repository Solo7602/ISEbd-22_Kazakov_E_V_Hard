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
	public partial class FormBulldozer : Form
	{
		private IBulldozer bulldozer;
		public FormBulldozer()
		{
			InitializeComponent();
		}
		private void Draw()
		{
			Bitmap bmp = new Bitmap(Picture.Width, Picture.Height);
			Graphics gr = Graphics.FromImage(bmp);
			bulldozer.DrawTransport(gr);
			Picture.Image = bmp;
		}
		private void buttonCreate_Click(object sender, EventArgs e)
		{
			Random rnd = new Random();
			bulldozer = new ModBuldozer(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Blue,
		   Color.Yellow, true, true, comboBoxType.SelectedIndex, countWheels.SelectedIndex);
			bulldozer.SetPosition(rnd.Next(100, 200), rnd.Next(100, 200), Picture.Width, Picture.Height);
			Draw();
		}
		private void buttonMove_Click(object sender, EventArgs e)
		{
			//получаем имя кнопки
			string name = (sender as Button).Name;
			switch (name)
			{
				case "buttonUp":
					bulldozer.MoveTransport(Direction.Up);
					break;
				case "buttonDown":
					bulldozer.MoveTransport(Direction.Down);
					break;
				case "buttonLeft":
					bulldozer.MoveTransport(Direction.Left);
					break;
				case "buttonRight":
					bulldozer.MoveTransport(Direction.Right);
					break;
			}
			Draw();
		}
    }
}
