 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChickenWare.Framework;

namespace HighlyDivisibleTriangularNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfRequiredDividers = 500;

            int triangularNumber = 0;
            int index = 1;

            while (NumberOfDividers(triangularNumber) < 500)
            {
                triangularNumber += index;
                index++;                
            }

            Console.WriteLine("The first triangular number with {0} dividers is : {1}", numberOfRequiredDividers, triangularNumber);
            Console.ReadLine();
        }

        private static int NumberOfDividers(int number)
        {
            int numberOfDividers = 0;
            int sqrt = (int) Math.Sqrt(number);

            for (int i = 1; i < sqrt; i++)
            {
                if (number % i == 0)
                    numberOfDividers += 2;
            }

            //correction if the number is a perfect square
            if (sqrt * sqrt == number)
            {
                numberOfDividers--;
            }

            return numberOfDividers;
        }
    }
}
