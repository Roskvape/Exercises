using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk1_Operators_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            float xx = 6.5f;
            float yy = -6.5f;
            bool compare = xx > 1.5f;

            //Exercise One
            Console.WriteLine("Exercise One");
            Console.WriteLine("Current value of x = " + x);
            Console.WriteLine("\nMethod One (x=x+5):");
            x = x + 5;
            Console.WriteLine(x);
            Console.WriteLine("\nMethod Two (++x):");
            x = 0;
            ++x;
            ++x;
            ++x;
            ++x;
            ++x;
            Console.WriteLine(x);
            Console.WriteLine("\nMethod Three (x+=5):");
            x = 0;
            x += 5;
            Console.WriteLine(x);
            Console.WriteLine("\nMethod Four (x++) and while loop:");
            x = 0;
            while (x < 5)
                {
                x++;
                }
            Console.WriteLine(x);

            //Exercise Two
            Console.WriteLine("\n\nExercise Two");
            x = 3;
            x = x * x;
            Console.WriteLine("x^2 = " + x);
            x *= 3;
            Console.WriteLine("\nx^3 = " + x);
            x *= 3;
            Console.WriteLine("\nx^4 = " + x);

            //Exercise Three
            Console.WriteLine("\n\nExercise Three");
            Console.WriteLine("Prediction: xx > 1.5 will be true.");
            Console.WriteLine("compare = " + compare);

            //Exercise Four
            Console.WriteLine("\n\nExercise Four");
            Console.WriteLine("Prediction: xx > yy will be true.");
            compare = xx > yy;
            Console.WriteLine("compare = " + compare);

            Console.WriteLine("\n\nPrediction: xx <= 6.5f will be true.");
            compare = xx <= 6.5f;
            Console.WriteLine("compare = " + compare);

            Console.WriteLine("\n\nPrediction: 6.5f == yy will be false.");
            compare = 6.5f == yy;
            Console.WriteLine("compare = " + compare);

            Console.WriteLine("\n\nPrediction: xx < yy || xx > yy will be true.");
            compare = xx < yy || xx > yy;
            Console.WriteLine("compare = " + compare);

            Console.WriteLine("\n\nPrediction: xx > 0f && yy > 0f will be false.");
            compare = xx > 0f && yy > 0f;
            Console.WriteLine("compare = " + compare);

            Console.WriteLine("\n\nPrediction: xx * -1f == yy will be true.");
            compare = xx * -1f == yy;
            Console.WriteLine("compare = " + compare);

            Console.WriteLine("\n\nPrediction: xx != yy && xx < yy will be false.");
            compare = xx != yy && xx < yy;
            Console.WriteLine("compare = " + compare);


            Console.ReadKey();
        }
    }
}
