using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace labaBuldozerKazakovISEbd_22
{
    class Wheels
    {
        private enumWheel wheel;
        public int WheelCount { set => wheel = (enumWheel)value; }
        public void DrawWheels(Graphics g, float startPosX, float startPosY)
        {
            switch (wheel)
            {
                case enumWheel.Four:
                    DrawWheelsFour(g, startPosX, startPosY);
                    break;

                case enumWheel.Five:
                    DrawWheelsFive(g, startPosX, startPosY);
                    break;

                case enumWheel.Six:
                    DrawWheelsSix(g, startPosX, startPosY);
                    break;
            }
        }
        Pen pen = new Pen(Color.Black, 4);
        Brush brBlack = new SolidBrush(Color.Black);
        public void DrawWheelsFour(Graphics g, float x, float y)
        {
            g.DrawEllipse(pen, x + 100, y + 111, 10, 10);
            g.DrawEllipse(pen, x + 135, y + 111, 10, 10);
            g.DrawEllipse(pen, x + 165, y + 111, 10, 10);
            g.DrawEllipse(pen, x + 180, y + 111, 10, 10);
            g.FillEllipse(brBlack, x + 100, y + 111, 10, 10);
            g.FillEllipse(brBlack, x + 135, y + 111, 10, 10);
            g.FillEllipse(brBlack, x + 165, y + 111, 10, 10);
            g.FillEllipse(brBlack, x + 180, y + 111, 10, 10);
        }
        public void DrawWheelsFive(Graphics g, float x, float y)
        {
            DrawWheelsFour(g, x, y);
            g.DrawEllipse(pen, x + 185, y + 140, 10, 10);
            g.DrawEllipse(pen, x + 185, y + 140, 10, 10);
            g.FillEllipse(brBlack, x + 185, y + 140, 10, 10);
        }
        public void DrawWheelsSix(Graphics g, float x, float y)
        {
            DrawWheelsFive(g, x, y);
            g.DrawEllipse(pen, x + 90, y + 140, 10, 10);
            g.FillEllipse(brBlack, x + 90, y + 140, 10, 10);
        }
    }
}
