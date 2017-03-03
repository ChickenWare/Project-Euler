using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenFibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxNumber = 4000000;
            List<int> EvenFibonacciNumbers = new List<int>();

            List<int> fibonacciNumbers = new List<int>();
            fibonacciNumbers.Add(0);
            fibonacciNumbers.Add(1);
            fibonacciNumbers.Add(2);
            EvenFibonacciNumbers.Add(2);

            while (fibonacciNumbers.Last() < maxNumber)
            {
                fibonacciNumbers.RemoveAt(0);
                fibonacciNumbers.Add(fibonacciNumbers.Sum());
                if (fibonacciNumbers.Last() < maxNumber && fibonacciNumbers.Last() % 2 == 0)
                    EvenFibonacciNumbers.Add(fibonacciNumbers.Last());
            }

            int sumOfEvenNumbers = EvenFibonacciNumbers.Sum();

            Console.WriteLine(string.Format("Sum of even Fibonacci numbers below {0} is : {1}",maxNumber,sumOfEvenNumbers));
            Console.ReadLine();
        }


    }
}
