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

            List<string> allThreeDigitsProductsAsString = allThreeDigitsProducts.ToList().ConvertAll(s=> s.ToString());
            allThreeDigitsProductsAsString.Reverse();

            string highestPalindrome = string.Empty;
            foreach (string productResult in allThreeDigitsProductsAsString)
            {
                if (productResult == ReverseString(productResult))
                {
                    highestPalindrome = productResult;
                    break;
                }
            }

            Console.WriteLine(highestPalindrome);

            Console.ReadLine();
        
        }

        static string ReverseString(string input)
        {
            char[] inputArray = input.ToCharArray();
            Array.Reverse(inputArray);
            return new string(inputArray);
        }
    }
}
