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
        private readonly List<T> _places;
        private readonly int _maxCount;
        private readonly int pictureWidth;
        private readonly int pictureHeight;
        private readonly int _placeSizeWidth = 305;
        private readonly int _placeSizeHeight = 157;
        public Parking(int picWidth, int picHeight)
        {
            int width = picWidth / _placeSizeWidth;
            int height = picHeight / _placeSizeHeight;
            _maxCount = width * height;
            pictureWidth = picWidth;
            pictureHeight = picHeight;
            _places = new List<T>();
        }
        public static bool operator +(Parking<T, W> p, T bulldozer)
        {
            if (p._places.Count >= p._maxCount)
            {
                return false;
            }
            p._places.Add(bulldozer);
            return true;
        }
        public static T operator -(Parking<T, W> p, int index)
        {
            if (index < -1 || index > p._places.Count)
            {
                return null;
            }
            T bulldozer = p._places[index];
            p._places.RemoveAt(index);
            return bulldozer;
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
        public void Draw(Graphics g)
        {
            int changeHeight = 10;
            int width = pictureWidth / _placeSizeWidth;
            DrawMarking(g);
            for (int i = 0; i < _places.Count; i++)
            {
                _places[i].SetPosition(i % width * _placeSizeWidth + changeHeight,
                                    i / width * _placeSizeHeight + changeHeight, pictureWidth,
                                    pictureHeight);
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
        public T this[int ind]
        {
            get
            {
                if (ind > -1 && ind < _places.Count)
                    return _places[ind];
                return null;
            }
            set
            {
                if (ind > -1 && ind < _places.Count)
                    _places[ind] = value;
            }
        }
    }
}
