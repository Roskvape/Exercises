using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagonalDifference
{
    class Program
    {
        static int diagonalDifference(int[][] arr)
        {
            int iSum1 = 0;
            int iSum2 = 0;
            int iDiff = 0;

            for (int i = 0; i < arr[0].Length; i++)
            {
                iSum1 += arr[i][i];
            }

            for (int i = 0; i < arr[0].Length; i++)
            {
                iSum2 += arr[arr[0].Length-1 - i][i];
            }

            iDiff = Math.Abs(iSum1 - iSum2);

            return iDiff;

        }
        static void Main(string[] args)
        {
            int[][] arr = new int[3][];
            arr[0] = new int[] { 1, 2, 3 };
            arr[1] = new int[] { 4,5,6 };
            arr[2] = new int[] { 7,8,9 };

            diagonalDifference(arr);
        }
    }
}
