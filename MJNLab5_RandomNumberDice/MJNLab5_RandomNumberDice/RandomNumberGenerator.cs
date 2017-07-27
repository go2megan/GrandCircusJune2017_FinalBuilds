using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MJNLab5_RandomNumberDice
{
    public class RandomNumberGenerator
    {
        static int RandomGenerator(int n, int d)

        {

            Random rand1 = new Random();
            Random rand2 = new Random();

            int sum = rand1.Next(1, 7) + rand2.Next(1, 7);
            int count = 1;

            {
                sum = rand1.Next(1, 7) + rand2.Next(1, 7);
                count++;
            }

            return count;

        }
    }
}
