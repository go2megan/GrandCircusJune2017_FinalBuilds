using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MJNB13_ParkingLot2
{
    public class TheLot
    {

        public static int CountSpots(string park)
        {
            throw new NotImplementedException();
        }

        public static string autos { get; private set; }
        public static string spots { get; private set; }
        public static string count { get; private set; }


        public static string GetAuto(int vehicle)
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
        public static string GetSpots(int vehicle)
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
            if (vehicle == 1 && park == "y" || vehicle == 1 && park == "Y" || vehicle == 2 && park == "y" || vehicle == 2 && park == "Y" || vehicle == 3 && park == "y" || vehicle == 3 && park == "Y")
            {
                private int park = 1;
        private int b = 45;
                for()
    }
}
    }
}
