using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    class Program
    {
        static int DiagonalDifference(int[,] arr)
        {
            // Get sum of primary diagonal

            int length = arr.GetLength(0);
            int pd = 0;
            int j = 0;
            for (int i = 0; i < length; ++i)
            {
                pd += arr[i, j];
                ++j;
            }

            // Get sum of secondary diagonal

            int sd = 0;
            j = length - 1;
            for (int i = 0; i < length; ++i)
            {
                sd += arr[i, j];
                --j;
            }

            // Return absolute difference

            return Math.Abs(pd - sd);
            
        }

        static void Main(string[] args)
        {
            // Test case

            Console.WriteLine("Test 1");

            int[,] test1 = new int[3, 3] { { 2, 3, 4 }, { 5, 6, 7 }, { 8, 9, 1 } };
            Console.WriteLine("Expected result: 9\nFunction result: {0}", DiagonalDifference(test1));

            Console.WriteLine("Test 2");

            int[,] test2 = new int[4, 4] { { 1,9,10,5 }, { 11,2,6,12 }, { 13,7,3,14 }, { 8, 15, 16, 4 } };
            Console.WriteLine("Expected result: 16\nFunction result: {0}", DiagonalDifference(test2));

        }
    }
}
