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

            Spacecraft spaceCraft = new Spacecraft(sMake, sModel);


            Console.WriteLine("You have a brand-new ship!");
            Console.WriteLine("Make: " + spaceCraft.Make);
            Console.WriteLine("Model: " + spaceCraft.Model);

            Console.WriteLine("Add how many crew? (Max: " + spaceCraft.CrewCapacity + ")");
            spaceCraft.CurrentCrew += Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("You have a new crew!");
            Console.WriteLine("Crew: " + spaceCraft.CurrentCrew);

            Console.WriteLine("Add how many crew? (Max: " + spaceCraft.CrewCapacity + ")");
            spaceCraft.CurrentCrew += Convert.ToInt16(Console.ReadLine());

            Console.ReadKey();
        }
    }
}
