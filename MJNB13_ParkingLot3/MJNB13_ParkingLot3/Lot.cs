using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MJNB13_ParkingLot3
{
    public class Lot
    {
        int vehicle;
        string autos;
        int spots;
        string park;

        public string TheLot(int vehicle)
        {
            //get
            //{
            //this.vehicle = new vehicle;
            //    this.autos = new autos;
            //    this.spots = new spots;
            //    this.park = new park;
            //}
        }

        public static string GetAuto(int vehicle, string autos)
        {
            if (vehicle == 1)
            {
                autos = "car";
            }
            else if (vehicle == 2)
            {
                autos = "motorcycle";
            }
            else if (vehicle == 3)
            {
                autos = "bus";
            }
            return autos;

        }
        public static string GetSpots(int vehicle, string spots)
        {
            if (vehicle == 1)
            {
                spots = "medium";
            }
            else if (vehicle == 2)
            {
                spots = "small";
            }
            else if (vehicle == 3)
            {
                spots = "large";
            }
            return spots;
        }

        public static string CountSpots(string park, int vehicle)
        {
            int d = 45;

            List<Vehicle> vehicle = new List<Vehicle>;
            list.Add(d, 45);




    }
}
    }
}
