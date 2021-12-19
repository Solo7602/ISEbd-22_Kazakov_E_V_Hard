using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Reflection;

namespace labaBuldozerKazakovISEbd_22
{
    public class ModBuldozer : BuldozerBase, IEquatable<BuldozerBase>, IComparable, IEnumerator<PropertyInfo>, IEnumerable<PropertyInfo>
    {
        private enumWheel dopEnum;
        public Color DopColor { private set; get; }
        public bool BackSpoiler { private set; get; }
        public bool Bucket { private set; get; }
        public int Wheel { set => dopEnum = (enumWheel)value; }
        private InterDop interdop;
        public string IDopName => interdop.GetType().Name;
        public ModBuldozer(int maxSpeed, float weight, Color mainColor, Color dopColor, bool backSpoiler, bool bucket,int BulldozerType, int numwheels) :
            base(maxSpeed, weight, mainColor, 100, 60)
        {
            DopColor = dopColor;
            BackSpoiler = backSpoiler;
            Bucket = bucket;
            Wheel = numwheels;
            switch (BulldozerType)
            {
                case 0:
                    interdop = new SimpleWheel(numwheels);
                    break;
                case 1:
                    interdop = new RhombWheel(numwheels);
                    break;
                case 2:
                    interdop = new RectangleWheel(numwheels);
                    break;
            }
        }
        public ModBuldozer(string info) : base(info)
        {
            string[] strs = info.Split(separator);
            if (strs.Length == 7)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromArgb(Convert.ToInt32(strs[2]));
                DopColor = Color.FromArgb(Convert.ToInt32(strs[3]));
                BackSpoiler = Convert.ToBoolean(strs[4]);
                Bucket = Convert.ToBoolean(strs[5]);
                switch (strs[6])
                {
                    case "SimpleWheel":
                        interdop = new SimpleWheel(2);
                        break;
                    case "RhombWheel":
                        interdop = new RhombWheel(2);
                        break;
                    case "RectangleWheel":
                        interdop = new RectangleWheel(2);
                        break;
                }
            }
        }
        public override void DrawTransport(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            Brush dopBrush = new SolidBrush(DopColor);
            if (BackSpoiler)
            {
                g.DrawLine(pen, _startPosX + 220, _startPosY + 71, _startPosX + 250, _startPosY + 51);
                g.DrawLine(pen, _startPosX + 220, _startPosY + 91, _startPosX + 250, _startPosY + 51);
                g.DrawRectangle(pen, _startPosX + 230, _startPosY + 31, 40, 20);
                g.FillRectangle(dopBrush, _startPosX + 230, _startPosY + 31, 40, 20);
            }
            if (Bucket)
            {
                g.DrawLine(pen, _startPosX + 70, _startPosY + 76, _startPosX + 40, _startPosY + 76);
                g.DrawLine(pen, _startPosX + 40, _startPosY + 51, _startPosX + 40, _startPosY + 151);
                g.DrawLine(pen, _startPosX + 40, _startPosY + 151, _startPosX, _startPosY + 151);
                g.DrawLine(pen, _startPosX, _startPosY + 151, _startPosX + 40, _startPosY + 51);

            }
            base.DrawTransport(g);
            interdop.DrawDop(g, _startPosX, _startPosY);
        }
        public void SetIDop(InterDop idop)
        {
            this.interdop = idop;
        }
        public void SetDopColor(Color color)
        {
            DopColor = color;
        }
        public override string ToString()
        {
            return
           $"{base.ToString()}{separator}{DopColor.ToArgb()}{separator}{BackSpoiler}{separator}{Bucket}{separator}{interdop.GetType().Name}";
        }
        public bool Equals(ModBuldozer other)
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
            if (DopColor != other.DopColor)
            {
                return false;
            }
            if (BackSpoiler != other.BackSpoiler)
            {
                return false;
            }
            if (Bucket != other.Bucket)
            {
                return false;
            }
            if (IDopName != other.IDopName)
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
            if (!(obj is ModBuldozer carObj))
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
            if (!(obj is ModBuldozer carObj))
            {
                return -1;
            }
            else
            {
                return CompareTo(carObj);
            }
        }
        public int CompareTo(ModBuldozer obj)
        {

            var res = base.CompareTo(obj);
            if (res != 0)
            {
                return res;
            }
            if (DopColor != obj.DopColor)
            {
                return DopColor.Name.CompareTo(obj.DopColor.Name);
            }
            if (BackSpoiler != obj.BackSpoiler)
            {
                return BackSpoiler.CompareTo(obj.BackSpoiler);
            }
            if (Bucket != obj.Bucket)
            {
                return Bucket.CompareTo(obj.Bucket);
            }
            if (IDopName != obj.IDopName)
            {
                return IDopName.CompareTo(obj.IDopName);
            }
            return 0;
        }
        private void printProp()
        {
            foreach (var str in this.ToString().Split(separator))
            {
                Console.WriteLine(str);
            }
        }
    }
}
