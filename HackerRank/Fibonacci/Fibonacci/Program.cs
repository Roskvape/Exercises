using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        public static int Fibonacci(int n)
        {
            int iSeed1 = 0;
            int iSeed2 = 1;
            int iCurrent = 0;
            
            for (int i = 0; i < n-1; i++)
            {
                iCurrent = iSeed1 + iSeed2;
                iSeed1 = iSeed2;
                iSeed2 = iCurrent;
            }

            return iCurrent;
        }

        static void Main(string[] args)
        {

            int n = 5;

            Console.WriteLine(Fibonacci(n));

            Console.ReadKey();
        }
    }
}
