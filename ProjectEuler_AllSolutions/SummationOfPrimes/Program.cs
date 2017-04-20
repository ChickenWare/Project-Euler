using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChickenWare.Framework;

namespace SummationOfPrimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxNumber = 2000000;

            List<int> allPrimeNumbersToSum = Helpers.FindPrimeNumbersBelow(maxNumber);

            long sum=0;
            foreach (var prime in allPrimeNumbersToSum)
                sum += prime;

            Console.WriteLine("Sum of all prime numbers below {0} = {1}",maxNumber,sum);
            Console.ReadLine();

        }
    }
}
