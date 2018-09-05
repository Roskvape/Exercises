using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimumMoves
{
    class Program
    {
        static int minimumMoves(List<int> a, List<int> m)
        {
            int iMoves = 0;

            for (int iCount = 0; iCount < a.Count; iCount++)
            {
                string sAndrea = Convert.ToString(a[iCount]);
                string sMaria = Convert.ToString(m[iCount]);

                for (int i = 0; i < sAndrea.Length; i++)
                {
                    iMoves += Math.Abs(sAndrea[i] - sMaria[i]);
                }
            }
            return iMoves;
        }

        static void Main(string[] args)
        {
            List<int> Andrea = new List<int> { 0000, 0000 };
            List<int> Maria = new List<int> { 0000, 0090 };

            Console.WriteLine(minimumMoves(Andrea, Maria));

            Console.ReadKey();


        }
    }
}
