using System;
namespace Projects.MJNorton_PreWork
{
    public class MJNReverseANumber
    {
        static void Main(string[] args)
        {
            int aNum, NumRev = 0;
            Console.WriteLine("Enter a 4 digit number");
            // the integer aNum assigns the value the user will enter, NumRev is zero a condition to stop the program
            aNum = int.Parse(Console.ReadLine());
            //insures that the entered value will convert from string to integer
            while (aNum != 0)
                //stops the program from searching for more numbers to parse and reverse
            {//alorithm that moves say 1, 2, 3, 4 through 10's position and cycles through rotating the values to zero
                NumRev = NumRev * 10;
                NumRev = NumRev + aNum % 10;
                aNum = aNum / 10;
            }
            Console.WriteLine("The reverse number is {0}", NumRev);
            Console.ReadLine();
            //pushes the message to interface as say 4321
        }
    }
}