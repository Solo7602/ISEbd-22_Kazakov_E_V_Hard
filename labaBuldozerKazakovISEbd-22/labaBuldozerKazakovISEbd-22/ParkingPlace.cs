using System;
using NLog;
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
		private readonly Logger logger;
		public ParkingPlace()
		{
			InitializeComponent();
			parkingCollection = new ParkingCollection(pictureBoxPark.Width,
pictureBoxPark.Height);
			queue = new Queue<VehicleBuldozer>();
			Draw();
			logger = LogManager.GetCurrentClassLogger();
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
					logger.Info($"Удалили парковку{ listBoxParking.SelectedItem.ToString()}");

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
							logger.Warn("Парковка переполнена");
						}
					}
				}
			}

		}

		private void buttonInQueue_Click(object sender, EventArgs e)
		{
			if (listBoxParking.SelectedIndex > -1 && maskedTextBoxNumber.Text != "")
			{
				try
				{
					var bul = parkingCollection[listBoxParking.SelectedItem.ToString()] -
				  Convert.ToInt32(maskedTextBoxNumber.Text);
					Random rand = new Random();

					if (bul != null)
					{
						FormBulldozer form = new FormBulldozer();
						queue.Enqueue(bul);
						logger.Info($"Изъят бульдозер {bul} с { maskedTextBoxNumber.Text}");

						Draw();
					}
				}
				catch (ParkingNotFoundException ex)
				{
					MessageBox.Show(ex.Message, "Не найдено", MessageBoxButtons.OK,
				   MessageBoxIcon.Error);
					logger.Error("Парковка переполнена");
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Неизвестная ошибка",
				   MessageBoxButtons.OK, MessageBoxIcon.Error);
					logger.Error("Ошибка изъятия бульдозера");
				}
			}
		}
		private void buttonAddParking_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(textBoxName.Text))
			{
				MessageBox.Show("Введите название парковки", "Ошибка",
			   MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			logger.Info($"Добавили парковку {textBoxName.Text}");
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
                else
				{
					logger.Fatal("В очередь занесено неправильное значение");
				}
			}
			Draw();
		}
		private void AddBul(VehicleBuldozer bul)
		{
			if (bul != null && listBoxParking.SelectedIndex > -1)
			{
                try
				{
					if ((parkingCollection[listBoxParking.SelectedItem.ToString()]) + bul)
					{
						Draw();
						logger.Info($"Добавлен автомобиль {bul}");
					}
					else
					{
						logger.Error("Машину не удалось поставить");
						MessageBox.Show("Машину не удалось поставить");
					}
					Draw();
				}
				catch (ParkingOverflowException ex)
				{
					MessageBox.Show(ex.Message, "Переполнение", MessageBoxButtons.OK,
					MessageBoxIcon.Error);
					logger.Warn("Парковка переполнен");
				}
				catch (Exception ex)
				{
					logger.Fatal("Вызвана неизвестная ошибка");
					MessageBox.Show(ex.Message, "Неизвестная ошибка",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}

		}

	private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
			if (saveFileDialog1.ShowDialog() == DialogResult.OK)
			{
				try
				{
					parkingCollection.SaveData(saveFileDialog1.FileName);
					MessageBox.Show("Сохранение прошло успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information); logger.Info("Сохранено в файл " + saveFileDialog1.FileName);
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
					logger.Warn("Неизвестная ошибка при сохранении");
				}
			}
		}

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				try
				{
					parkingCollection.LoadData(openFileDialog1.FileName);
					MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
					logger.Info("Загружено из файла " + openFileDialog1.FileName);
					ReloadLevels();
					Draw();
				}
				catch (ParkingOccupiedPlaceException ex)
				{
					MessageBox.Show(ex.Message, "Занятое место", MessageBoxButtons.OK, MessageBoxIcon.Error);
					logger.Error("Занятое место");
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении",
				   MessageBoxButtons.OK, MessageBoxIcon.Error);
					logger.Fatal("Неизвестная ошибка");
				}
			}
		}

        private void сохранитьПарковкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
			if (saveFileDialog1.ShowDialog() == DialogResult.OK)
			{
				try
				{
					parkingCollection.LoadData(openFileDialog1.FileName);
					MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK,
					MessageBoxIcon.Information);
					logger.Info("Загрузили парковку из файла " + openFileDialog1.FileName);
					ReloadLevels();
					Draw();
				}
				catch (ParkingOccupiedPlaceException ex)
				{
					MessageBox.Show(ex.Message, "Занятое место", MessageBoxButtons.OK,
				   MessageBoxIcon.Error);
					logger.Error("Занятое место");
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Неизвестная ошибка при загрузке",
				   MessageBoxButtons.OK, MessageBoxIcon.Error);
					logger.Error("Ошибка Загрузки");
				}
			}
		}

        private void загрузитьПарковкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				try
				{
					parkingCollection.SaveDataPark(saveFileDialog1.FileName, listBoxParking.SelectedItem.ToString());
					MessageBox.Show("Сохранение прошло успешно", "Результат",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
					logger.Info("Сохранили парковку в файл " + saveFileDialog1.FileName);
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении",
				   MessageBoxButtons.OK, MessageBoxIcon.Error);
					logger.Error("Ошибка сохраниения");
				}
			}
		}

    }
}




