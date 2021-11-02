using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace labaBuldozerKazakovISEbd_22
{
    class SimpleWheel : InterDop
    {
        private enumWheel dopEnum;
        public int Wheel { set => dopEnum = (enumWheel)value; }
        public SimpleWheel(int x)
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
            g.FillEllipse(brBlack, x + 100, y + 111, 10, 10);
            g.FillEllipse(brBlack, x + 135, y + 111, 10, 10);
            g.FillEllipse(brBlack, x + 165, y + 111, 10, 10);
            g.FillEllipse(brBlack, x + 180, y + 111, 10, 10);
            if (dopEnum == enumWheel.Five || dopEnum == enumWheel.Six)
            {
                g.DrawEllipse(pen, x + 185, y + 140, 10, 10);
                g.DrawEllipse(pen, x + 185, y + 140, 10, 10);
                g.FillEllipse(brBlack, x + 185, y + 140, 10, 10);
            }
            if (dopEnum == enumWheel.Six)
            {
                g.DrawEllipse(pen, x + 90, y + 140, 10, 10);
                g.FillEllipse(brBlack, x + 90, y + 140, 10, 10);
            }
            
        }
    }
}
