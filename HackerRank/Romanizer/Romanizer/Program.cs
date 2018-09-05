using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Romanizer
{
    class Program
    {
        static List<string> romanizer(List<int> numbers)
        {
            List<string> lRomanized = new List<string>();
  
            string s1 = "I";
            string s5 = "V";
            string s10 = "X";

            foreach (int i in numbers)
            {
                string sNumber = Convert.ToString(i);
                string sRomanized = "";

                for (int xChar = 0; xChar < sNumber.Length; xChar++)
                {
                    switch (sNumber.Length - xChar - 1)
                    {
                        case 3:
                            s1 = "M";
                            break;
                        case 2:
                            s1 = "C";
                            s5 = "D";
                            s10 = "M";
                            break;
                        case 1:
                            s1 = "X";
                            s5 = "L";
                            s10 = "C";
                            break;
                        case 0:
                            s1 = "I";
                            s5 = "V";
                            s10 = "X";
                            break;
                    }

                    switch (sNumber[xChar])
                    {
                        case '1':
                            sRomanized += $"{s1}";
                            break;
                        case '2':
                            sRomanized += $"{s1}{s1}";
                            break;
                        case '3':
                            sRomanized += $"{s1}{s1}{s1}";
                            break;
                        case '4':
                            sRomanized += $"{s1}{s5}";
                            break;
                        case '5':
                            sRomanized += $"{s5}";
                            break;
                        case '6':
                            sRomanized += $"{s5}{s1}";
                            break;
                        case '7':
                            sRomanized += $"{s5}{s1}{s1}";
                            break;
                        case '8':
                            sRomanized += $"{s5}{s1}{s1}{s1}";
                            break;
                        case '9':
                            sRomanized += $"{s1}{s10}";
                            break;
                    }

                }

                lRomanized.Add(sRomanized);
            }

            return lRomanized;
        }

        static void Main(string[] args)
        {
            List<int> Roman = new List<int> { 39, 246 };

            foreach (string s in romanizer(Roman))
            {
                Console.WriteLine(s);
            }
            
            Console.ReadKey();


        }
    }
}
