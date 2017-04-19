using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialPythagoreanTriplet
{
    class Program
    {
        static void Main(string[] args)
        {
            int Sumabc = 1000;

            for ( int a =1 ; a< Sumabc; a++)
                for (int b= 1; b < Sumabc;b++)
                    for (int c = 1; c < Sumabc; c++)
                    {
                        if (a+b+c == 1000)
                            if (a * a + b * b == c * c)
                            {
                                Console.WriteLine("The Pythagorean triplet for which a+b+c = 1000 has as product a*b*c = {0} where a ={1}, b={2}, c={3}", a * b * c, a, b, c);
                                Console.ReadLine();
                            }
                    }
 
        }
    }
}
