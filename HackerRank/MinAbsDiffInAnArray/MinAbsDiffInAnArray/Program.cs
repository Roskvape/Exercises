using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinAbsDiffInAnArray
{
    class Program
    {
        static int minimumAbsoluteDifference(int[] arr)
        {
            List<int> iList = new List<int>();

            iList = arr.ToList();
            iList.Sort();

            int iMinDiff = 0;

            for (int i = 0; i < iList.Count(); i++)
            {
                if (i == 0)
                {
                    iMinDiff = Math.Abs(iList[i] - iList[i + 1]);
                }
                else
                {
                    if (Math.Abs(iList[i] - iList[i-1]) < iMinDiff)
                    {
                        iMinDiff = Math.Abs(iList[i] - iList[i-1]);
                    }
                }

            }
            return iMinDiff;
        }

        static void Main(string[] args)
        {
            int[] arr = { 3, -7, 0 };

            Console.WriteLine(minimumAbsoluteDifference(arr));

            Console.ReadKey();
        }
    }
}
