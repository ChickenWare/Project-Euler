using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallestMultiple
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxDivider = 20;
            bool IsSmallestMultipleFound = false;
            int answer = 0;

            for (int i = maxDivider; !IsSmallestMultipleFound; i++)
            {
                for (int j = 2; j <= maxDivider; j++)
                {
                    if (!IsEvenlyDividable(i, j))
                        break;

                    if (j == maxDivider)
                        IsSmallestMultipleFound = true;

                }

                if (IsSmallestMultipleFound)
                    answer = i;
            }

            Console.WriteLine("SmallestMultiple = {0}", answer);
            Console.ReadLine();
        }

        static bool IsEvenlyDividable(int number, int divider)
        {
            return number % divider == 0;
        }
    }
}
