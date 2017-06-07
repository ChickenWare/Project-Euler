using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace PowerDigitSum
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger resultOfPower = 0;

            resultOfPower = BigInteger.Pow(2, 1000);

            string result = resultOfPower.ToString();

            var resultAsNumberSequence = result.Select(c => c - '0').ToArray();

            int sumOfPower = resultAsNumberSequence.Sum();
        }
    }
}
