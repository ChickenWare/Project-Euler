using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace LargestProductInASeries
{
    class Program
    {
        /// <summary>
        /// Look for highest multiple of 13 adjacent numbers
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            List<string> AllPossibleProducts = new List<string>();
            List<ulong> AllProducts = new List<ulong>();

            string pattern =  @"73167176531330624919225119674426574742355349194934
                                96983520312774506326239578318016984801869478851843
                                85861560789112949495459501737958331952853208805511
                                12540698747158523863050715693290963295227443043557
                                66896648950445244523161731856403098711121722383113
                                62229893423380308135336276614282806444486645238749
                                30358907296290491560440772390713810515859307960866
                                70172427121883998797908792274921901699720888093776
                                65727333001053367881220235421809751254540594752243
                                52584907711670556013604839586446706324415722155397
                                53697817977846174064955149290862569321978468622482
                                83972241375657056057490261407972968652414535100474
                                82166370484403199890008895243450658541227588666881
                                16427171479924442928230863465674813919123162824586
                                17866458359124566529476545682848912883142607690042
                                24219022671055626321111109370544217506941658960408
                                07198403850962455444362981230987879927244284909188
                                84580156166097919133875499200524063689912560717606
                                05886116467109405077541002256983155200055935729725
                                71636269561882670428252483600823257530420752963450";

            pattern = Regex.Replace(pattern, @"\s+", string.Empty);

            AllPossibleProducts = ExtractAllProductsOfAdjacentNumbers(pattern,13);
            FilterTrivialNullProducts(AllPossibleProducts);

            AllProducts = ComputeAllProducts(AllPossibleProducts);

            Console.WriteLine("Max product of 13 adjactent numbers = {0}", AllProducts.Max());
            Console.ReadLine();
        }

        private static List<ulong> ComputeAllProducts(List<string> AllPossibleProducts)
        {
            List<ulong> AllResults = new List<ulong>();

            foreach (var product in AllPossibleProducts)
            {
                ulong result = 1;
                
                for (int i = 0; i < product.Length ; i++)
                {
                    result = result * (ulong) Char.GetNumericValue(product[i]);
                }
               
                AllResults.Add(result);
            }
            return AllResults;
        }

        private static void FilterTrivialNullProducts(List<string> AllPossibleProducts)
        {
            foreach (var product in AllPossibleProducts.ToList())
            {
                if (product.Contains("0"))
                    AllPossibleProducts.Remove(product);
            }
        }

        private static List<string> ExtractAllProductsOfAdjacentNumbers(string pattern, int amountAdjacentNumbersRequired)
        {
            List<string> AllProducts = new List<string>();

            for (int i = 0; i <= pattern.Length - amountAdjacentNumbersRequired ; i++)
            {
                AllProducts.Add(pattern.Substring(i, amountAdjacentNumbersRequired));
            }
            return AllProducts;
        }


    }
}
