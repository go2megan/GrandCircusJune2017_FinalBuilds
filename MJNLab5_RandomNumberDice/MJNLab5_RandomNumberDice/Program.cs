using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MJNLab5_RandomNumberDice
{
    class Program
    {
        public static string count { get; private set; }

        public static void Main()
        {
            int n, d; //n = number of dice, i=sides of dice
            string answer = "y";
            RandomNumberGenerator r = new RandomNumberGenerator();
           
            {
                Console.Write("Welcome! Let's learn about random numbers by rolling dice.\n");
            }
            while (answer == "y")
            {
                { 
                    //Ask for the number of dice
                    Console.Write("Input the number of dice we should roll (1 - 6):\n");
                    n = Convert.ToInt32(Console.ReadLine());

                    //Ask for the sides of dice
                    Console.Write("Input the number of sides each dice should have (1 - 6):\n");
                    d = Convert.ToInt32(Console.ReadLine());

                    int rolls = RandomGenerator();
                    Console.WriteLine("The number of rolls are:" + count);

                }

                Console.WriteLine("Go again?  Learn about more numbers? (Yes = y, No = n)?");
                answer = Console.ReadLine();
            }

        }

        private static int RandomGenerator()
        {
            throw new NotImplementedException();
        }
    }
}