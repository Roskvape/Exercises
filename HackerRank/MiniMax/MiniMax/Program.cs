using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniMax
{
    class Program
    {
        static void miniMaxSum(int[] arr)
        {
            long longSum = 0;
            long minSum = 0;
            long maxSum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                longSum += arr[i];
            }

            minSum = longSum - arr.Max();
            maxSum = longSum - arr.Min();

            Console.WriteLine(minSum + " " + maxSum);
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };

            miniMaxSum(arr);
        }
    }
}
