using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingSundays
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime start = new DateTime(1901, 01, 1);
            DateTime end = new DateTime(2000, 12, 31);

            DateTime tmp = start;

            int numberOfSundays = 0;

            while (tmp != end)
            {
                if (tmp.DayOfWeek == DayOfWeek.Sunday && tmp.Day == 1)
                    numberOfSundays++;

                tmp = tmp.AddDays(1);
            }

            Console.WriteLine("Number of sundays = {0}",numberOfSundays);
            Console.ReadLine();
        }
    }
}
