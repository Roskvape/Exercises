using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiLo
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rRando = new Random();
            int iActual = rRando.Next(1,100);

            int iGuess = 0;

            Console.WriteLine("\nGuess a number between 1 and 100:");
            while (iActual != iGuess)
            {
                Console.WriteLine("\nEnter your guess:");
                iGuess = Convert.ToInt16(Console.ReadLine());

                //Add error handling

                if (iActual > iGuess)
                {
                    Console.WriteLine("Too Low!");
                }
                else if (iActual < iGuess)
                {
                    Console.WriteLine("Too High!");
                }
                else
                {
                    Console.WriteLine("\nYou guessed correctly! The answer is " + iActual);
                }
            }


            Console.ReadKey();
        }
    }
}
