using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10001stPrime
{
    class Program
    {
        /// <summary>
        /// Notes: We know there exist pi(x) prime number below X
        /// 
        /// Tables show pi(105000) = 10024 prime numbers below 105000.
        /// We shall list all primes below 105000 and select the 10001
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
        }

        static bool IsPrimeNumber(int number)
        {
            double maxDivider = Math.Sqrt(number);

            Dictionary<int,bool> listOfPotentialDivider = new Dictionary<int,bool>();

            for (int i = 2; i <= maxDivider; i++)
            {
                listOfPotentialDivider.Add(i, true);
            }
        }
    }
}
