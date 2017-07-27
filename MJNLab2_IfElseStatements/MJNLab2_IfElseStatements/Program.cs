using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MJNLab2_IfElseStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            double input;
            string answer = "y"; //always keep this in here for a continue loop, til it's replaced by a method

            {
                Console.WriteLine("Welcome! Let's learn about odd and even numbers.");
            }
            while (answer == "y")
            {
                Console.WriteLine("Enter a number between 1 and 100:");
                input = double.Parse(Console.ReadLine());

                if (input % 2 != 0 && input < 60 && input >=1 && input < 100) // Odd condtions
                {
                    Console.WriteLine(input + " is an Odd number");
                }
                else if (input % 2 != 0 && input >= 60 && input >= 1 && input < 100) //Has errors because 64 prints odd and even
                {
                    Console.WriteLine(input + " is an Odd number over 60");
                }
                else if (input % 2 == 0 && input > 25 && input >=2 && input < 00) // Even conditions
                {
                    Console.WriteLine(input + " is an Even number");
                }
                else if (input % 2 == 0 && input >= 2 && input >= 2 && input < 100)
                {
                    Console.WriteLine(input + " is and Even number between 2 and 25");
                }
                else if (input % 2 == 0 && input <= 25 && input >= 2 && input < 100)
                {
                    Console.WriteLine(input + " is and Even number between 2 and 25");
                }
                else if (input <=1 && input >=100)
                {
                    Console.WriteLine(input + "Input Error");
                }
            }
            Console.WriteLine("Go again?  Learn about more numbers? (Yes = y, No = n)?");
            answer = Console.ReadLine();
        }
    }
}