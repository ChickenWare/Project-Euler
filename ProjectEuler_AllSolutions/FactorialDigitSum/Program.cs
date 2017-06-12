using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Numerics;
using Microsoft.SolverFoundation.Common;

namespace FactorialDigitSum
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger _result = 0;

            _result = BigInteger.Factorial(100);

            string result = _result.ToString();

            var sumOfResultNumbers = result.Select(c => c - '0').ToArray();


            Console.WriteLine("Sum of numbers in result: {0}",sumOfResultNumbers.Sum());
            Console.ReadLine();
        }
    }
}
