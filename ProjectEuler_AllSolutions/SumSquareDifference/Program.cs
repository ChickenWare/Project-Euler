using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumSquareDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 100;
            int answer = SquaresOfSumOfFirstXNaturalNumbers(number) - SumOfSquaresOfFirstXNaturalNumbers(number);

            Console.WriteLine("Sum square difference = {0}", answer);
            Console.ReadLine();
        }

        static int SumOfSquaresOfFirstXNaturalNumbers(int X)
        {
            int sumOfSquares = 0;
            for (int i = 1; i <= X; i++)
            {
                sumOfSquares += i * i;
            }
            return sumOfSquares;
        }

        static int SquaresOfSumOfFirstXNaturalNumbers(int X)
        {
            int sum = 0;
            for (int i = 1; i <= X; i++)
            {
                sum += i;
            }
            return sum * sum;
        }
    }
}
