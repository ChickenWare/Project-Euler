using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestPalindromeProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<int> allThreeDigitsProducts = new SortedSet<int>();

            for (int i = 999; i >99; i--)
            {
                for (int j = 999; j > 99; j--)
                {
                    allThreeDigitsProducts.Add(i * j);
                }
            }

            allThreeDigitsProducts.ToList().ToString();

            Console.ReadLine();
            
        }
    }
}
