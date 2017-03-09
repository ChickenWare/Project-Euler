using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestPrimeFactor
{
    class Program
    {
        static void Main(string[] args)
        {
            long numberToFindLargestPrimeFactorsFor = 600851475143;

            List<long> allFactors = Factor(numberToFindLargestPrimeFactorsFor);

            foreach (var factor in allFactors)
                Console.WriteLine(factor);

            Console.ReadLine();
        }

        static List<long> Factor(long number)
        {
            List<long> allFactors = new List<long>();
            long restOfFactorisation = number;

            for (long factor = 2; restOfFactorisation != 1; factor++)
            {
                if (restOfFactorisation % factor == 0)
                {
                    allFactors.Add(factor);
                    restOfFactorisation = restOfFactorisation / factor;
                    factor = 2;
                }
            }            

            return allFactors;
        }
    }
}
