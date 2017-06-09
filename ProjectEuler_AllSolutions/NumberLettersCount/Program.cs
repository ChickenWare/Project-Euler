using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberLettersCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> specialNumbers = new Dictionary<int, string>
            {
                {1, "one"},
                {2, "two"},
                {3,"three"},
                {4,"four"},
                {5,"five"},
                {6,"six"},
                {7,"seven"},
                {8,"eight"},
                {9,"nine"},
                {10,"ten"},
                {11,"eleven"},
                {12,"twelve"},
                {13,"thirteen"},
                {14,"fourteen"},
                {15,"fifteen"},
                {16, "sixteen"},
                {17,"seventeen"},
                {18,"eighteen"},
                {19,"nineteen"},
                {20,"twenty"},
                {30,"thirty"},
                {40,"forty"},
                {50,"fifty"},
                {60,"sixty"},
                {70,"seventy"},
                {80,"eighty"},
                {90,"ninety"},
                {100, "hundred"},
                {1000,"thousand"}
            };

            List<string> allNumbers = new List<string>();

            for (int i = 1; i <= 1000; i++)
            {
                Console.WriteLine("Checking {0}", i);
                int tmpi = i;
                string tmpNum = string.Empty;
                if (i == 1000)
                {
                    tmpNum = "one " + specialNumbers[1000];
                    allNumbers.Add(tmpNum);
                    continue;
                }
                if (i >= 100)
                {
                    int hundreds = (int) i / 100;
                    tmpNum = specialNumbers[hundreds] + " " + specialNumbers[100];
                    tmpi -= 100 * hundreds;
                }
                if (tmpi < 100)
                {
                    if (tmpi == 0)
                    {
                        allNumbers.Add(tmpNum);
                        continue;
                    }
                    if (tmpi > 20)
                    {
                        if (i > 100)
                        {
                            tmpNum += " and ";
                        }
                        int tens = (int)tmpi / 10;
                        tmpNum += specialNumbers[tens * 10];
                        tmpi -= 10 * tens;
                    }
                    else
                    {
                        if (i > 100)
                        {
                            tmpNum += " and " ;
                        }
                        tmpNum += specialNumbers[tmpi];
                        allNumbers.Add(tmpNum);
                        continue;
                    }

                    if (tmpi < 10)
                    {
                        if (tmpi != 0)
                        {
                            tmpNum += " " + specialNumbers[tmpi];
                        }

                        allNumbers.Add(tmpNum);
                        continue;
                    }
                    else
                    {
                        throw new Exception();
                    }

                }
                
            }
            
            int totalLetters = 0;
            int cmpt = 0;
            foreach (var number in allNumbers)
            {
                cmpt++;
                if (cmpt == 342)
                {
                    int a;
                }
                string tmp = number.Replace(" ","");
                totalLetters += tmp.Length;
            }

            Console.WriteLine("Sum of all letters = {0}", totalLetters);
            Console.ReadLine();
        }
    }
}
