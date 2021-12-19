using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Reflection;

namespace labaBuldozerKazakovISEbd_22
{
    public class BuldozerBase : VehicleBuldozer, IEquatable<BuldozerBase>, IComparable, IEnumerator<PropertyInfo>, IEnumerable<PropertyInfo>
    {
        /// <summary>
        /// Ширина отрисовки автомобиля
        /// </summary>
        protected readonly int BulldozerWidth = 240;
        /// <summary>
        /// Высота отрисовки автомобиля
        /// </summary>
        protected readonly int BulldozerHeight = 152;
        protected readonly char separator = ';';
        public int currentIndex = -1;
        private PropertyInfo[] myPropertyInfo => Type.GetType("ShipBasic").GetProperties();
        public PropertyInfo Current => myPropertyInfo[currentIndex];
        object IEnumerator.Current => myPropertyInfo[currentIndex];
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес автомобиля</param>
        /// <param name="mainColor">Основной цвет кузова</param>
        public BuldozerBase(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }
        public BuldozerBase(string info)
        {
            string[] strs = info.Split(separator);
            if (strs.Length == 3)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromArgb(Convert.ToInt32(strs[2]));
            }
        }
        /// <summary>
        /// Конструкторс изменением размеров машины
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес автомобиля</param>
        /// <param name="mainColor">Основной цвет кузова</param>
        /// <param name="carWidth">Ширина отрисовки автомобиля</param>
        /// <param name="carHeight">Высота отрисовки автомобиля</param>
        protected BuldozerBase(int maxSpeed, float weight, Color mainColor, int BulldozerWidth, int
       BulldozerHeight)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            this.BulldozerWidth = BulldozerWidth;
            this.BulldozerHeight = BulldozerHeight;
        }
        public override void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - BulldozerWidth)
                    {
                        _startPosX += step;
                    }
                    break;
                //влево
                case Direction.Left:
                    if (_startPosX - step > 0)
                    {
                        _startPosX -= step;
                    }
                    break;
                //вверх
                case Direction.Up:
                    if (_startPosY - step > 0)
                    {
                        _startPosY -= step;
                    }
                    break;
                //вниз
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - BulldozerHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }
        public override void DrawTransport(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            g.DrawRectangle(pen, _startPosX + 70, _startPosY + 51, 150, 50);
            Brush brRed = new SolidBrush(MainColor);
            g.FillRectangle(brRed, _startPosX + 71, _startPosY + 52, 149, 50);
            Brush brBlue = new SolidBrush(Color.Blue);
            g.DrawRectangle(pen, _startPosX + 89, _startPosY, 20, 50);
            g.FillRectangle(brBlue, _startPosX + 90, _startPosY + 2, 20, 50);
            g.DrawRectangle(pen, _startPosX + 170, _startPosY + 2, 50, 50);
            g.DrawLine(pen, _startPosX + 70, _startPosY + 101, _startPosX + 220, _startPosY + 101);
            g.DrawLine(pen, _startPosX + 70, _startPosY + 151, _startPosX + 220, _startPosY + 151);
            g.DrawArc(pen, _startPosX + 50, _startPosY + 101, 50, 50, 90, 180);
            g.DrawArc(pen, _startPosX + 190, _startPosY + 101, 50, 50, 270, 180);
            Pen roll = new Pen(Color.Black, 4);
            g.DrawEllipse(roll, _startPosX + 100, _startPosY + 130, 20, 20);
            g.DrawEllipse(roll, _startPosX + 130, _startPosY + 130, 20, 20);
            g.DrawEllipse(roll, _startPosX + 160, _startPosY + 130, 20, 20);
            g.DrawEllipse(roll, _startPosX + 150, _startPosY + 111, 10, 10);
            g.DrawEllipse(roll, _startPosX + 120, _startPosY + 111, 10, 10);
            g.DrawEllipse(roll, _startPosX + 55, _startPosY + 106, 40, 40);
            g.DrawEllipse(roll, _startPosX + 195, _startPosY + 106, 40, 40);
            g.DrawLine(pen, _startPosX + 120, _startPosY + 51, _startPosX + 120, _startPosY + 40);
            g.DrawLine(pen, _startPosX + 140, _startPosY + 51, _startPosX + 140, _startPosY + 40);
            g.DrawArc(pen, _startPosX + 120, _startPosY + 30, 20, 20, 180, 180);
        }
        public override string ToString()
        {
            return $"{MaxSpeed}{separator}{Weight}{separator}{MainColor.ToArgb()}";
        }
        public bool Equals(BuldozerBase other)
        {
            if (other == null)
            {
                return false;
            }
            if (GetType().Name != other.GetType().Name)
            {
                return false;
            }
            if (MaxSpeed != other.MaxSpeed)
            {
                return false;
            }
            if (Weight != other.Weight)
            {
                return false;
            }
            if (MainColor != other.MainColor)
            {
                return false;
            }
            return true;
        }

        public override bool Equals(Object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is BuldozerBase carObj))
            {
                return false;
            }
            else
            {
                return Equals(carObj);
            }
        }

        public int CompareTo(Object obj)
        {
            if (obj == null)
            {
                return -1;
            }
            if (!(obj is BuldozerBase carObj))
            {
                return -1;
            }
            else
            {
                return CompareTo(carObj);
            }
        }
        public int CompareTo(BuldozerBase obj)
        {
            if (MaxSpeed != obj.MaxSpeed)
            {
                return MaxSpeed.CompareTo(obj.MaxSpeed);
            }
            if (Weight != obj.Weight)
            {
                return Weight.CompareTo(obj.Weight);
            }
            if (MainColor != obj.MainColor)
            {
                return MainColor.Name.CompareTo(obj.MainColor.Name);
            }
            return 0;
        }
        private void printProp()
        {
            foreach (var prop in this)
            {
                Console.WriteLine(prop.Name.ToString());
            }
        }

        public void Dispose() { }
        public bool MoveNext()
        {
            currentIndex++;
            if (currentIndex >= myPropertyInfo.Length)
            {
                Reset();
                return false;
            }
            return true;
        }

        public void Reset()
        {
            currentIndex = -1;
        }

        public IEnumerator<PropertyInfo> GetEnumerator()
        {
            return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this;
        }
    }
}
