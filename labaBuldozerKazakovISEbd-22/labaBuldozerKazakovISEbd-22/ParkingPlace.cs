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
		private readonly ParkingCollection parkingCollection;
		private Queue<VehicleBuldozer> queue;
		public ParkingPlace()
		{
			InitializeComponent();
			parkingCollection = new ParkingCollection(pictureBoxPark.Width,
pictureBoxPark.Height);
			queue = new Queue<VehicleBuldozer>();
			Draw();
		}
		private void ReloadLevels()
		{
			int index = listBoxParking.SelectedIndex;
			listBoxParking.Items.Clear();
			for (int i = 0; i < parkingCollection.Keys.Count; i++)
			{
				listBoxParking.Items.Add(parkingCollection.Keys[i]);
			}
			if (listBoxParking.Items.Count > 0 && (index == -1 || index >=
		   listBoxParking.Items.Count))
			{
				listBoxParking.SelectedIndex = 0;
			}
			else if (listBoxParking.Items.Count > 0 && index > -1 && index <
		   listBoxParking.Items.Count)
			{
				listBoxParking.SelectedIndex = index;
			}
		}

		private void Draw()
		{
			if (listBoxParking.SelectedIndex > -1)
			{
				Bitmap bmp = new Bitmap(pictureBoxPark.Width, pictureBoxPark.Height);
				Graphics gr = Graphics.FromImage(bmp);
				parkingCollection[listBoxParking.SelectedItem.ToString()].Draw(gr);
				pictureBoxPark.Image = bmp;
			}
		}

		private void buttonParking_Click(object sender, EventArgs e)
		{
			var formCFG = new FormCFG();
			formCFG.AddEvent(AddBul);
			formCFG.Show();


		}

		private void buttonDelete_Click(object sender, EventArgs e)
		{
			if (listBoxParking.SelectedIndex > -1)
			{
				if (MessageBox.Show($"Удалить парковку { listBoxParking.SelectedItem.ToString()}?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					parkingCollection.DelParking(textBoxName.Text);
					ReloadLevels();
				}
			}
		}
		private void listBoxParking_SelectedIndexChanged(object sender, EventArgs e)
		{
			Draw();
		}

		private void buttonModParking_Click(object sender, EventArgs e)
		{
			if (listBoxParking.SelectedIndex > -1)
			{
				ColorDialog dialog = new ColorDialog();
				if (dialog.ShowDialog() == DialogResult.OK)
				{
					ColorDialog dialogDop = new ColorDialog();
					if (dialogDop.ShowDialog() == DialogResult.OK)
					{
						var bulldozer = new ModBuldozer(100, 1000, dialog.Color,
					   dialogDop.Color, true, true,2,2);
						if (parkingCollection[listBoxParking.SelectedItem.ToString()]
+ bulldozer)
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

		}

        private void buttonInQueue_Click(object sender, EventArgs e)
        {
			if (listBoxParking.SelectedIndex > -1 && maskedTextBoxNumber.Text != "")
			{
				var buldozer = parkingCollection[listBoxParking.SelectedItem.ToString()] -
					Convert.ToInt32(maskedTextBoxNumber.Text);
				queue.Enqueue(buldozer);
			}
			Draw();
		}
		private void buttonAddParking_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(textBoxName.Text))
			{
				MessageBox.Show("Введите название парковки", "Ошибка",
			   MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			parkingCollection.AddParking(textBoxName.Text);
			ReloadLevels();

		}

		private void buttonOutQueue_Click(object sender, EventArgs e)
        {
			if (queue.Count > 0)
			{
				var bull = queue.Dequeue();
				if (bull != null)
				{
					FormBulldozer form = new FormBulldozer();
					Random rand = new Random();
					bull.SetPosition(rand.Next(150), rand.Next(150), form.Size.Width, form.Size.Height);
					form.SetBulldozer(bull);
					form.ShowDialog();
				}
			}
			Draw();
		}
		private void AddBul(VehicleBuldozer car)
		{
			if (car != null && listBoxParking.SelectedIndex > -1)
			{
				if ((parkingCollection[listBoxParking.SelectedItem.ToString()]) + car)
				{
					Draw();
				}
				else
				{
					MessageBox.Show("Машину не удалось поставить");
				}
			}
		}
	}
}




