using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string sChar = "1";
            int iChar = int.Parse(sChar);

            Console.WriteLine(sChar);

            Console.WriteLine("Adding 4");

            iChar = iChar + 4;

            sChar = Convert.ToString(iChar);

            Console.WriteLine(sChar);

            Console.ReadKey();
        }
    }
}
