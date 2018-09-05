using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayCakeCandles
{
    class Program
    {
        static int birthdayCakeCandles(int[] ar)
        {
            int iTallest = ar.Max();
            int iHowMany = 0;

            foreach (int i in ar)
            {
                if (i == iTallest)
                {
                    iHowMany++;
                }
            }

            return iHowMany;
        }

        static void Main(string[] args)
        {
            int[] ar = { 3, 2, 1, 3 };

            birthdayCakeCandles(ar);
        }
    }
}
