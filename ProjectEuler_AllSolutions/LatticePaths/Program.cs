using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatticePaths
{
    class Program
    {
        static void Main(string[] args)
        {
            // The number of latice path is given by C(n + k,k) where we start at (0,0) and try to arrive at (20,20) = (n,k)
            //C(40,20) = 137846528820.
            Console.WriteLine("Answer = {0}", 137846528820);
        }
    }
}
