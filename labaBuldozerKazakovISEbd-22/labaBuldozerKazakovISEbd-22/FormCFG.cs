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
    public partial class FormCFG : Form
    {
        IBulldozer bulldozer = null;
        public event Action<VehicleBuldozer> eventAddBul;
        public FormCFG()
        {
            InitializeComponent();
            this.panelBlack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            this.panelYellow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            this.panelPurple.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            this.panelSilver.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            this.panelGreen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            this.panelOrange.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            this.panelBlue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            this.panelRed.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            buttonCancel.Click += (object sender, EventArgs e) => { Close(); };
        }
        private void DrawTransport()
        {
            if (bulldozer != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxBul.Width, pictureBoxBul.Height);
                Graphics gr = Graphics.FromImage(bmp);
                bulldozer.SetPosition(5, 5, pictureBoxBul.Width, pictureBoxBul.Height);
                bulldozer.DrawTransport(gr);
                pictureBoxBul.Image = bmp;
            }
        }


        private void labelBul_MouseDown(object sender, MouseEventArgs e)
        {
            labelBul.DoDragDrop(labelBul.Text, DragDropEffects.Move |
DragDropEffects.Copy);
        }

        private void labelMod_MouseDown(object sender, MouseEventArgs e)
        {
            labelMod.DoDragDrop(labelMod.Text, DragDropEffects.Move |
DragDropEffects.Copy);
        }

        private void panelBul_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Обычный бульдозер":
                    bulldozer = new BuldozerBase((int)numericUpDown1.Value, (int)numericUpDown2.Value, Color.White);
                    break;
                case "Улучшенный бульдозер":
                    bulldozer = new ModBuldozer((int)numericUpDown1.Value, (int)numericUpDown2.Value, Color.White, Color.Black, checkBox1.Checked, checkBox2.Checked,
                   2, 2);
                    break;
            }
            else if (bulldozer is ModBuldozer)
            {
                (bulldozer as ModBuldozer).SetIDop((InterDop)e.Data.GetData(e.Data.GetFormats()[0]));
            }
            DrawTransport();
        }

        private void panelBul_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text) ||
                typeof(InterDop).IsAssignableFrom(Type.GetType(e.Data.GetFormats()[0])))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }

        }

        private void labelMainColor_DragDrop(object sender, DragEventArgs e)
        {
            bulldozer.SetMainColor((Color)e.Data.GetData(typeof(Color)));
            DrawTransport();
        }

        private void labelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            if (bulldozer is ModBuldozer)
            {
                (bulldozer as ModBuldozer).SetDopColor((Color)e.Data.GetData(typeof(Color)));
                DrawTransport();
            }
        }
        public void AddEvent(Action<VehicleBuldozer> ev)
        {
            if (eventAddBul == null)
            {
                eventAddBul = new Action<VehicleBuldozer>(ev);
            }
            else
            {
                eventAddBul += ev;
            }
        }

        private void labelMainColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            {
                Color color = (sender as Panel).BackColor;
                (sender as Panel).DoDragDrop(color, DragDropEffects.Move | DragDropEffects.Copy);
            }
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            eventAddBul?.Invoke((VehicleBuldozer)bulldozer);
            Close();
        }

        private void Simple_MouseDown(object sender, MouseEventArgs e)
        {
            InterDop temp = new SimpleWheel(2);
            labelMod.DoDragDrop(temp, DragDropEffects.Move |
DragDropEffects.Copy);
        }

        private void Rhomb_MouseDown(object sender, MouseEventArgs e)
        {
            InterDop temp = new RhombWheel(2);
            labelMod.DoDragDrop(temp, DragDropEffects.Move |
DragDropEffects.Copy);
        }

        private void Rectangle_MouseDown(object sender, MouseEventArgs e)
        {
            InterDop temp = new RectangleWheel(2);
            labelMod.DoDragDrop(temp, DragDropEffects.Move |
DragDropEffects.Copy);
        }
    }
}
