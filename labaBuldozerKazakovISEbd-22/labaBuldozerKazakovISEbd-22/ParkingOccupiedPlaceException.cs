using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labaBuldozerKazakovISEbd_22
{
	class ParkingOccupiedPlaceException : Exception
	{
		public ParkingOccupiedPlaceException() : base("Место занято")
		{ }
	}
}
