using System;

namespace MJNorton_DateDiff
{
    class MJNorton_DateDiff
    {
        static void Main()
        {
            DateTime dob;
            DateTime today = DateTime.Now;

            Console.WriteLine("Enter your Date of Birth in dd/mm/yyyy format:");
            dob = Convert.ToDateTime(Console.ReadLine()).Date;

            TimeSpan difference = today.Subtract(dob);

            Console.WriteLine("You are " + difference.Days + " apart in days.");
            Console.WriteLine("You are " + difference.Days/30 + " apart in months.");
            Console.WriteLine("You are " + difference.Days /365 + " apart in months.");
            Console.ReadLine();
        }
    }
}
