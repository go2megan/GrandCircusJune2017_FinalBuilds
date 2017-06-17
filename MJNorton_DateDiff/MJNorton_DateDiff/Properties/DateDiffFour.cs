using System;
namespace MJNorton_DateDiff
{
	public class DateDiffFour
	{
		static void Main(string[] args)
		{
			//Assign Variables
            DateTime YourDob;
			DateTime MyDob;

            //Ask for Two Variables at the same time
			Console.WriteLine("Enter formatted dd/mm/yyy:");
            YourDob = Convert.ToDateTime(Console.ReadLine()).Date;
			
            Console.WriteLine("Enter a 2nd formated dd/mm/yyyy:");
            MyDob = Convert.ToDateTime(Console.ReadLine()).Date;

            //Subtract the variables
            TimeSpan difference = YourDob.Subtract(MyDob);
            //Months = difference / 30;
            //Years = difference / 365;

            Console.WriteLine("You are " + difference.TotalDays + " days apart in age.");
            Console.ReadLine();

			//Console.WriteLine("You are " + Months + " months apart in age.");
			//Console.ReadLine();

			//Console.WriteLine("You are " + Years + " years apart in age.");
			//Console.ReadLine();
		}
	}
}
