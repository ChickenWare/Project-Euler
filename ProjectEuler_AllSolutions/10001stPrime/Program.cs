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
            int PrimeNumberPositionWeAreLookingFor = 10001;
            List<int> allPrimeNumbers = FindPrimeNumbersBelow(105000);

            Console.WriteLine("The 10001st prime number is: {0}", allPrimeNumbers[PrimeNumberPositionWeAreLookingFor-1]);
            Console.ReadLine();
        }

        private static List<int> FindPrimeNumbersBelow(int number)
        {
            //double maxDivider = Math.Sqrt(number);

            Dictionary<int, bool> AllNumbersToTest = ListAllNumbersBelow(number);

            foreach (var tmpNumberToTest in AllNumbersToTest.Keys.ToList())
            {
                
                if (AllNumbersToTest[tmpNumberToTest] == true)
                {
                    //We are in the case it is still possible for the number to be prime
                    if (!IsPrimeNumber(tmpNumberToTest))
                    {
                        //number is not prime
                        AllNumbersToTest[tmpNumberToTest] = false; // It is not prime

                        int tmpNumber = tmpNumberToTest;
                        while (tmpNumber < number)
                        {
                            AllNumbersToTest[tmpNumber] = false;
                            tmpNumber += tmpNumberToTest; // we will not check the multiples of a number which we know is not prime
                        }

                    }
                }
            }

            List<int> allPrimeNumbers = AllNumbersToTest.Where(x => x.Value == true).Select(x => x.Key).ToList();
            return allPrimeNumbers;
        }

        private static Dictionary<int, bool> ListAllNumbersBelow(int maxNumber)
        {
            Dictionary<int, bool> listOfPotentialDivider = new Dictionary<int, bool>();

            for (int i = 2; i <= maxNumber; i++)
            {
                listOfPotentialDivider.Add(i, true);
            }
            return listOfPotentialDivider;
        }

        //This could be changed in a recursive using the algorithm above
        private static bool IsPrimeNumber(int number)
        {
            double limit = Math.Sqrt(number);
            for (int i = 2 ; i <= limit; i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }
    }
}
