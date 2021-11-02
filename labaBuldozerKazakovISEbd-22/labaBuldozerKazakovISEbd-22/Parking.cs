using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace labaBuldozerKazakovISEbd_22
{
    public class Parking<T, W>
        where T : class, IBulldozer
        where W : InterDop
    {
        private readonly T[] _places;
        private readonly int pictureWidth;
        private readonly int pictureHeight;
        private readonly int _placeSizeWidth = 305;
        private readonly int _placeSizeHeight = 157;
        public Parking(int picWidth, int picHeight)
        {
            int width = picWidth / _placeSizeWidth;
            int height = picHeight / _placeSizeHeight;
            _places = new T[width * height];
            pictureWidth = picWidth;
            pictureHeight = picHeight;
        }
        public static int operator +(Parking<T, W> p, T car)
        {
            int changeSize = 0;
            int width = p.pictureWidth / p._placeSizeWidth;

            for (int i = 0; i < p._places.Length; i++)
            {
                if (p.CheckFreePlace(i))
                {
                    p._places[i] = car;
                    p._places[i].SetPosition(i % width * p._placeSizeWidth + changeSize, i / width * p._placeSizeHeight + changeSize + 3, p.pictureWidth, p.pictureHeight);
                    return i;
                }
            }
            return -1;
        }
        public static T operator -(Parking<T, W> p, int index)
        {
            if (index < 0 || index > p._places.Length)
            {
                return null;
            }
            if (!p.CheckFreePlace(index))
            {
                T vehicle = p._places[index];
                p._places[index] = null;
                return vehicle;
            }
            return null;
        }

        public static bool operator >=(Parking<T,W> p, int d)
        {
            int x = 0;
            for(int i = 0; i < p.pictureHeight; i++)
            {
                if(p._places[i] == null)
                {
                    x += 1;
                }
            }
            return x >= d;
        }
        public static bool operator <=(Parking<T, W> p, int d)
        {
            int x = 0;
            for (int i = 0; i < p.pictureHeight; i++)
            {
                if (p._places[i] != null)
                {
                    x += 1;
                }
            }
            return x <= d;
        }
        private bool CheckFreePlace(int indexPlace)
        {
            return _places[indexPlace] == null;
        }
        public void Draw(Graphics g)
        {
            DrawMarking(g);
            for (int i = 0; i < _places.Length; i++)
            {
                _places[i]?.DrawTransport(g);
            }
        }
        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
            for (int i = 0; i < pictureWidth / _placeSizeWidth; i++)
            {
                for (int j = 0; j < pictureHeight / _placeSizeHeight + 1; ++j)
                {
                    g.DrawLine(pen, i * _placeSizeWidth, j * _placeSizeHeight, i *
                   _placeSizeWidth + _placeSizeWidth / 2, j * _placeSizeHeight);
                }
                g.DrawLine(pen, i * _placeSizeWidth, 0, i * _placeSizeWidth,
               (pictureHeight / _placeSizeHeight) * _placeSizeHeight);
            }
        }
    }
}
