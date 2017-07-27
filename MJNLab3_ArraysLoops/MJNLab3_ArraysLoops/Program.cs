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
            int i;
            //int input;
            //int[] a = new int[20];
            int n = 5;
            string answer = "y"; //always keep this in here for a continue loop, til it's replaced by a method

            {
                Console.WriteLine("Welcome! Let's learn about squared and cubed numbers.\n");
            }
            while (answer == "y")
            {
                Console.WriteLine("Enter a number between 1 - 10:\n");
                i= int.Parse(Console.ReadLine());
                Console.WriteLine("# | S | C |");
                for (i = i; i <= n; i++)
                {
                    int s = (i * i);
                    int c = (i * i * i);                   
                    int[] a = { i, s, c };                   
                    Console.Write(i+ " | " +s+ " | " + c+ " | \n");

                }
                Console.WriteLine("Go again?  Learn about more numbers? (Yes = y, No = n)?");
                answer = Console.ReadLine();
            }
           
        }
    }
}