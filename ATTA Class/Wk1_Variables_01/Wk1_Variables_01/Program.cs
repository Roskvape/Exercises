using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk1_Variables_01
{
    class Program
    {
        static void Main(string[] args)
        {
            string sFirstHalf = "This is one half";
            string sSecondHalf = "of a sentence.";
            int myInt = 1000000000;
            long myLong = 10000000000;
            float myFloat = 1.123456789f;
            double myDouble = 1.123456789;

            //Exercise One
            Console.WriteLine("Exercise One");
            Console.WriteLine("Hello, this is a WriteLine.");
            Console.Write("Hello, this is a Write.");

            //Exercise Two
            Console.WriteLine("\n\nExercise Two");
            Console.WriteLine(sFirstHalf + " " + sSecondHalf);

            //Exercise Three
            Console.WriteLine("\n\nExercise Three");
            Console.WriteLine("myInt = " + myInt);
            Console.WriteLine("myLong = " + myLong);

            //Exercise Four
            Console.WriteLine("\n\nExercise Four");
            Console.WriteLine("myFloat = " + myFloat);
            Console.WriteLine("myDouble = " + myDouble);

            Console.ReadKey();
        }
    }
}
