using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveStaircase
{
    class Program
    {
        public static int iSeed1 = 1;
        public static int iSeed2 = 2;
        public static int iSeed3 = 4;
        public static int iCurrent = 0;

        static int RecursiveBit(int n)
        {

            for (int i = 0; i < n-3; i++)
            {
                iCurrent = iSeed1 + iSeed2 + iSeed3;

                iSeed1 = iSeed2;
                iSeed2 = iSeed3;
                iSeed3 = iCurrent; 
            }

            return iCurrent;
        }

        static int stepPerms(int n)
        {
            iCurrent = 0;
            iSeed1 = 1;
        iSeed2 = 2;
        iSeed3 = 4;
            switch (n)
            {
                case 0:
                    return 0;
                case 1:
                    return 1;
                case 2:
                    return 2;
                case 3:
                    return 4;
                default:
                    return RecursiveBit(n);
            }

        }

        static void Main(string[] args)
        {
            Console.WriteLine(stepPerms(0));
            Console.WriteLine(stepPerms(1));
            Console.WriteLine(stepPerms(2));
            Console.WriteLine(stepPerms(3));
            Console.WriteLine(stepPerms(4));
            Console.WriteLine(stepPerms(5));
            Console.WriteLine(stepPerms(7));

            Console.ReadKey();
        }
    }
}
