using System;
namespace MJNorton_DateDiff
{
    public class MJNorton_DateDiffTwo
    {
        static void Main(string[] args)
        {
            //DateTime myDob = DateTime.Now;
            DateTime myBirthdate = DateTime.Parse("12/13/1971");
            TimeSpan myAge = DateTime.Now.Subtract(myBirthdate);
            Console.WriteLine(myAge.TotalDays.ToString());
            Console.ReadLine();
        }
    }
}
