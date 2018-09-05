using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Build a Spacecraft!");
            Console.WriteLine("\nEnter a Make:");
            string sMake = Console.ReadLine();
            Console.WriteLine("\nEnter a Model:");
            string sModel = Console.ReadLine();
            Console.WriteLine("Is it a warship? (Y/N)");
            if (Console.ReadLine() == "Y")
            {
                Warship spaceCraft = new Warship(sMake, sModel);
            }
            else
            {
                Spacecraft spaceCraft = new Spacecraft(sMake, sModel);
            }

            Console.WriteLine("You have a brand-new ship!");
            Console.WriteLine(spaceCraft.Make);
            Console.WriteLine(spaceCraft.Model);

            Console.ReadKey();
        }
    }
}
