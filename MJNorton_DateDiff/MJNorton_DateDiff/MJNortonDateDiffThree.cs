using System;
namespace MJNorton_DateDiff
{
    public class MJNortonDateDiffThree
    {
        static void Main (string[] args)
        {
            int YourDob;
            int MyDob;

            Console.WriteLine("Enter"+YourDob "formatted dd/mm/yyy:");
            Console.ReadLine();
            Console.WriteLine("Enter"+MyDob "formated dd/mm/yyyy");
            Console.ReadLine();

            DateTime oldDate = new DateTime(YourDob);
            DateTime newDate = new DateTime(MyDob);

			// Difference in days, hours, and minutes.
			TimeSpan ts = newDate - oldDate;
			// Difference in days.
			int differenceInDays = ts.Days;

			Console.WriteLine("Difference in days: {0} ", differenceInDays);   
        }
    }
}
