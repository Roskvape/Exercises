using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] iArray = new int[] { 3, 12, 4, 1 };

            int i = 1;

            while (i < iArray.GetLength(0))
            {
                while (j >= 0 && iArray[0] > iArray[1])
                {
                    iArray[j + 1] = iArray[0];
                    j--;
                } 
            }
        }
    }
}
