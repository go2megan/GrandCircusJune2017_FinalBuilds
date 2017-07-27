using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MJNB13_ParkingLot2
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 1; // spots free. Move to a counter in a class. 
            int b = 20; // total spots. Move to a counter class called garage
            string answer = "n"; //always keep this in here for a continue loop, til it's replaced by a method
            //int count = (b -);
            //string autos = GetAuto(vehicle);
            //string spots = GetSpots(vehicle);
            //int numSpots = GetNumSpots(vehicle)
            TheSpots = new TheSpots();
            TheLot = new TheLot();

            {
                Console.WriteLine("Welcome to our Parking Garage!\nLet's help you park!");
                Console.WriteLine("Right now we have " + a + " spots open out of " + b + " spots total.");
            }
            while (answer == "n")
            {
                {
                    Console.WriteLine("What are you driving?  What do you need to park?");
                    Console.WriteLine("Enter 1 for car, 2 for motorcycle, 3 for bus.");
                    int vehicle = int.Parse(Console.ReadLine());
;
                    Console.WriteLine("Great! You have a " + autos + ".");
                    Console.WriteLine("Your vehicle can fit in a " + spots + " spot.");
                    Console.WriteLine("Park now? y for Yes, n for No:");
                    string park = Console.ReadLine();
                    //int count = 15;
                    //Console.WriteLine("You'll take one spot, leaving " +count+ " spots.");                    
                    //Console.WriteLine("Great. Proceed to this level:" +level+);
                    Console.WriteLine("We have this many of those spots:" + count);

                }
                Console.WriteLine("Did you park? (Yes = y, No = n)?");
                answer = Console.ReadLine();

            }


        }

    }
}