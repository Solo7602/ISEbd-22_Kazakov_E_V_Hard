using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace labaBuldozerKazakovISEbd_22
{
    interface InterDop
    {
        int Wheel { set; }
        void DrawDop(Graphics g, float x, float y);

    }
}
