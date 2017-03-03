using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplesOf3and5
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxNumberToFindMultiplesFor = 1000;

            if (args.Length == 1)
                maxNumberToFindMultiplesFor = Int32.Parse(args[0]);

            List<int> multipliers = new List<int>();
            multipliers.Add(3);
            multipliers.Add(5);

            HashSet<int> multiplesOf3or5 = new HashSet<int>();

            //Find multipliers
            foreach (var multiplier in multipliers)
            {
                int multiplierToAdd = multiplier;
                while (multiplierToAdd < maxNumberToFindMultiplesFor)
                {
                    multiplesOf3or5.Add(multiplierToAdd);
                    multiplierToAdd += multiplier;
                }
            }

            //Compute sum
            int sum = 0;
            foreach (var number in multiplesOf3or5)
            {
                sum += number;
            }

            Console.WriteLine(string.Format("The sum of multiples of 3 or 5 below {0} is : {1}",maxNumberToFindMultiplesFor,sum));
            Console.ReadLine();
        }
    }
}
