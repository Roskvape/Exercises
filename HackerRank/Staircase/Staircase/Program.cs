using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staircase
{
    class Program
    {
        static void staircase(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int x = 0; x < n-1-i; x++)
                {
                    Console.Write(" "); 
                }

                for (int y = 0; y <= i; y++)
                {
                    Console.Write("#"); 
                }
                Console.WriteLine("");
            }

        }
        static void Main(string[] args)
        {
            staircase(5);

            Console.ReadKey();
        }
    }
}
