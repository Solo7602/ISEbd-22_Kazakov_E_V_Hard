using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labaBuldozerKazakovISEbd_22
{
    public class ParkingCollection
    {
        readonly Dictionary<string, Parking<VehicleBuldozer, SimpleWheel>> parkingStages;
        public List<string> Keys => parkingStages.Keys.ToList();
        private readonly int pictureWidth;
        private readonly int pictureHeight;
        public ParkingCollection(int pictureWidth, int pictureHeight)
        {
            parkingStages = new Dictionary<string, Parking<VehicleBuldozer, SimpleWheel>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;                                     
        }
        public void AddParking(string name)
        {
            if (!parkingStages.ContainsKey(name))
            {
                parkingStages.Add(name, new Parking<VehicleBuldozer, SimpleWheel>(pictureWidth, pictureHeight));
            }
        }
        public void DelParking(string name)
        {
            if (parkingStages.ContainsKey(name))
            {
                parkingStages.Remove(name);
            }
        }
        public Parking<VehicleBuldozer, SimpleWheel> this[string ind]
        {
            get
            {
                    return parkingStages[ind];
            }
        }
        public VehicleBuldozer this[string ind, int ind2]
        {
            get
            {
                return parkingStages[ind][ind2];
            }
        }
    }
}
