using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlusMinus
{
    class Program
    {
        static void plusMinus(int[] arr)
        {
            float dRatioPos = 0f;
            float dRatioNeg = 0f;
            float dRatioZero = 0f;
            float iTotalPos = 0;
            float iTotalNeg = 0;
            float iTotalZero = 0;

            foreach (int i in arr)
            {
                if (arr.Length < 1)
                {
                    break;
                }
                else if (i > 0)
                {
                    iTotalPos++;
                }
                else if (i < 0)
                {
                    iTotalNeg++;
                }
                else
                {
                    iTotalZero++;
                }
            }

            dRatioPos = iTotalPos / arr.Length;
            dRatioNeg = iTotalNeg / arr.Length;
            dRatioZero = iTotalZero / arr.Length;

            Console.WriteLine(dRatioPos);
            Console.WriteLine(dRatioNeg);
            Console.WriteLine(dRatioZero);

        }

        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 0, -1, 0};

            plusMinus(arr);
        }
    }
}
