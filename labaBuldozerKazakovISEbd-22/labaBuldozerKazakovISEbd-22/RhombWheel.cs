using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace labaBuldozerKazakovISEbd_22
{
    class RhombWheel : InterDop
    {
        private enumWheel dopEnum;
        public int Wheel { set => dopEnum = (enumWheel)value; }
        public RhombWheel(int x)
        {
            Wheel = x;
        }

        public void DrawDop(Graphics g, float x, float y)
        {
            Pen pen = new Pen(Color.Black, 4);
            Brush brBlack = new SolidBrush(Color.Black);
            g.DrawEllipse(pen, x + 100, y + 111, 10, 10);
            g.DrawEllipse(pen, x + 135, y + 111, 10, 10);
            g.DrawEllipse(pen, x + 165, y + 111, 10, 10);
            g.DrawEllipse(pen, x + 180, y + 111, 10, 10);
            g.DrawLine(pen, x + 100, y + 116, x + 105, y + 111);
            g.DrawLine(pen, x + 105, y + 111, x + 110, y + 116);
            g.DrawLine(pen, x + 110, y + 116, x + 105, y + 121);
            g.DrawLine(pen, x + 105, y + 121, x + 100, y + 116);
            g.DrawLine(pen, x + 135, y + 116, x + 140, y + 111);
            g.DrawLine(pen, x + 140, y + 111, x + 145, y + 116);
            g.DrawLine(pen, x + 145, y + 116, x + 140, y + 121);
            g.DrawLine(pen, x + 140, y + 121, x + 135, y + 116);
            g.DrawLine(pen, x + 165, y + 116, x + 170, y + 111);
            g.DrawLine(pen, x + 170, y + 111, x + 175, y + 116);
            g.DrawLine(pen, x + 175, y + 116, x + 170, y + 121);
            g.DrawLine(pen, x + 170, y + 121, x + 165, y + 116);
            g.DrawLine(pen, x + 180, y + 116, x + 185, y + 111);
            g.DrawLine(pen, x + 185, y + 111, x + 190, y + 116);
            g.DrawLine(pen, x + 190, y + 116, x + 185, y + 121);
            g.DrawLine(pen, x + 185, y + 121, x + 180, y + 116);
            if (dopEnum == enumWheel.Five || dopEnum == enumWheel.Six)
            {
                g.DrawEllipse(pen, x + 185, y + 140, 10, 10);
                g.DrawLine(pen, x + 185, y + 145, x + 190, y + 140);
                g.DrawLine(pen, x + 190, y + 140, x + 195, y + 145);
                g.DrawLine(pen, x + 195, y + 145, x + 190, y + 150);
                g.DrawLine(pen, x + 190, y + 150, x + 185, y + 145);
            }
            if (dopEnum == enumWheel.Six)
            {
                g.DrawEllipse(pen, x + 90, y + 140, 10, 10);
                g.DrawLine(pen, x + 90, y + 145, x + 95, y + 140);
                g.DrawLine(pen, x + 95, y + 140, x + 100, y + 145);
                g.DrawLine(pen, x + 100, y + 145, x + 95, y + 150);
                g.DrawLine(pen, x + 95, y + 150, x + 90, y + 145);
            }
        }
    }
}
