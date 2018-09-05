using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeftRotation
{

    class Program
    {
        // Complete the rotLeft function below.
        static int[] rotLeft(int[] a, int d)
        {
            int[] iNew = new int[a.Length];
            for (int x = 0; x < a.Length; x++)
            {
                if (x+d >= a.Length)
                {
                    iNew[x] = a[x + d - a.Length];
                }
                else
                {
                iNew[x] = a[x + d];
                }
            }

            return iNew;

        }
        static void Main(string[] args)
        {
            int[] a = { 1,2,3,4,5};
            int d = 2;

            foreach (int x in rotLeft(a, d))
            {
                Console.WriteLine(x);
            }

            Console.ReadKey();
        }
    }
}
