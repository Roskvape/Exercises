using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void countSwaps(int[] a)
        {
            int iSwaps = 0;
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a.Length - 1; j++)
                {
                    // Swap adjacent elements if they are in decreasing order
                    if (a[j] > a[j + 1])
                    {
                        a[j] ^= a[j + 1];
                        a[j + 1] ^= a[j];
                        a[j] ^= a[j + 1];

                        iSwaps++;
                    }
                }

            }

            Console.WriteLine("Array is sorted in {0} swaps.", iSwaps);
            Console.WriteLine("First Element: {0}", a[0]);
            Console.WriteLine("Last Element: {0}", a[a.Length-1]);

        }

        static void Main(string[] args)
        {
        }
    }
}
