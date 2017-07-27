using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MJNLab4_ForLoopsFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer = "y";
            {
                Console.WriteLine("Welcome! Let's learn about factorials.");
            }
            while (answer == "y" || answer == "Y")
            {
                {
                    Console.WriteLine("Enter an integer that's greater than 0 but less than 10:");
                    long input = long.Parse(Console.ReadLine());
                    long total = FactorialM(input);
                    Console.WriteLine("The factorial of " + input + " is " + total);
                }
                Console.WriteLine("Go again?  Learn about more numbers? (Yes = y, No = n)?");
                answer = Console.ReadLine();
            }
            
        }
        public static long FactorialM(long input)
        {
            long total = 1;
            for (long i = 1; i <= input; i++)
            {
                total = total * i;
            }
            return total;
        }
    }
}