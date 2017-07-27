using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PressurePunch1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int l = 4;
            //int w = 5;

            //string answer = "Y";

            //while (string == "y" || string == "Y")
            {
                Console.WriteLine("Enter as length number here :");
                int l = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter a width number here:");
                int w = int.Parse(Console.ReadLine());
                int a = (l * w);
                int p = (l + w) * 2;
                Console.WriteLine("Area:" + a);
                Console.WriteLine("Perimeter:" + p);
            }
            Console.WriteLine("Continue y/n:");
            //string answer = Console.ReadLine();
        }
    }
}

