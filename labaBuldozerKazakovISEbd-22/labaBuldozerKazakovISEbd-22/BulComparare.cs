using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labaBuldozerKazakovISEbd_22
{
    class BulComparer : IComparer<VehicleBuldozer>
    {
        public int Compare(VehicleBuldozer x, VehicleBuldozer y)
        {

            if (x is ModBuldozer && y is ModBuldozer)
            {
                return ComparerModBul(x as ModBuldozer, y as ModBuldozer);
            }
            if (x is BuldozerBase && y is BuldozerBase)
            {
                return ComparerBul(x as BuldozerBase, y as BuldozerBase);
            }

            if (x is ModBuldozer && y is BuldozerBase)
            {
                return -1;
            }
            if (x is BuldozerBase && y is ModBuldozer)
            {
                return 1;
            }
            return 0;
        }
        private int ComparerBul(BuldozerBase x, BuldozerBase y)
        {
            if (x.MaxSpeed != y.MaxSpeed)
            {
                return x.MaxSpeed.CompareTo(y.MaxSpeed);
            }
            if (x.Weight != y.Weight)
            {
                return x.Weight.CompareTo(y.Weight);
            }
            if (x.MainColor != y.MainColor)
            {
                return x.MainColor.Name.CompareTo(y.MainColor.Name);
            }
            return 0;
        }
        private int ComparerModBul(ModBuldozer x, ModBuldozer y)
        {
            var res = ComparerBul(x, y);
            if (res != 0)
            {
                return res;
            }
            if (x.DopColor != y.DopColor)
            {
                return x.DopColor.Name.CompareTo(y.DopColor.Name);
            }
            if (x.BackSpoiler != y.BackSpoiler)
            {
                return x.BackSpoiler.CompareTo(y.BackSpoiler);
            }
            if (x.Bucket != y.Bucket)
            {
                return x.Bucket.CompareTo(y.Bucket);
            }
            if (x.IDopName != y.IDopName)
            {
                return x.IDopName.CompareTo(y.IDopName);
            }
            return 0;
        }
    }
}
