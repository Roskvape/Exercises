using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewYearChaos
{
    class Program
    {
        static int minimumBribes(int[] arr)
        {
            int iBribes = 0;

            string[] iNullable = new string[arr.Length];


            for (int i = 0; i < arr.Length; i++)
            {
                iNullable[i] = Convert.ToString(arr[i]); 
            }
            

            Console.WriteLine("Original:\n");
            foreach (int i in arr)
            {
                Console.Write(i);
            }

            iNullable[0] = "";
            iNullable[6] = "";

            Console.WriteLine("\nNullable:\n");
            foreach (string i in iNullable)
            {
                    Console.Write(i); 
            }

            Console.WriteLine("\n");
            Console.WriteLine(arr.Min());
            Console.WriteLine(arr.Max());

            Console.WriteLine(iNullable.Min());
            Console.WriteLine(iNullable.Max());

            Console.ReadKey();

            //bool bNewBribes = true;

            //while (bNewBribes)
            //{
            //    bNewBribes = false;
            //    for (int i = 0; i < arr.Length-1; i++)
            //    {
            //        if (arr[i] > arr[i+1])
            //        {
            //            //int iTemp = arr[arr[i] - 1];

            //            //arr[arr[i] - 1] = arr[i];
            //            //arr[i] = iTemp;

            //            arr[i] ^= arr[i+1];
            //            arr[i+1] ^= arr[i];
            //            arr[i] ^= arr[i+1];
            //            iBribes++;
            //            bNewBribes = true;
            //        }
            //    }
            //}

            return iBribes;
        }

        static void Main(string[] args)
        {
            int[] q = { 1, 3, 5, 2, 4, 6, 8 };

            Console.WriteLine(minimumBribes(q));

            Console.ReadKey();
        }
    }
}
