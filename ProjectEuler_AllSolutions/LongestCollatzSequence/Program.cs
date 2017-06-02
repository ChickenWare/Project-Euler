using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestCollatzSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            int longestSequence = 0;
            int sequenceSize = 0;
            bool sequenceCompleted = false;
            long sequenceNumber = 1;
            long startingNum = 0;

            Dictionary<long, int> CollatzSequenceLengthByStartingNumber = new Dictionary<long, int>();

            for (int i = 1; i <= 1000000; i++)
            {
                Console.WriteLine(string.Format("Starting number = {0}", i));
                sequenceCompleted = false;
                sequenceNumber = i;

                while (!sequenceCompleted)
                {
                    sequenceNumber = ComputeNextCollatzSequenceNumber(sequenceNumber);
                    
                    if (sequenceNumber == 1)
                        sequenceCompleted = true;

                    //if (CollatzSequenceLengthByStartingNumber.ContainsKey(sequenceNumber))
                    //{
                    //    sequenceSize += CollatzSequenceLengthByStartingNumber[sequenceNumber];
                    //    break;
                    //}
                    //else
                        sequenceSize++;
                }

                if (sequenceSize > longestSequence)
                {
                    longestSequence = sequenceSize;
                    startingNum = i;
                }

                CollatzSequenceLengthByStartingNumber.Add(i, sequenceSize);


                sequenceSize =0;
            }

            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;

            Console.WriteLine(string.Format("longuest Collatz size : {0} for {1}  ", longestSequence,startingNum));
            Console.WriteLine(string.Format("Execution time is: {0} ms ", elapsedMs));
            Console.ReadLine();
        }

        static long ComputeNextCollatzSequenceNumber(long number)
        {
            if (number == 1)
                return 1;

            if (number % 2 == 0)
                return number / 2;
            else
                return number * 3 + 1;
        }
    }
}
