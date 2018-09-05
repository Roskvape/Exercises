using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUD_v1
{
    class Program
    {


        static void Main(string[] args)
        {

            ConsoleKey ckInput = ConsoleKey.E;
            Player PlayerOne = new Player();

            Console.WriteLine("Please enter your name:");
            PlayerOne.PlayerName = Console.ReadLine();
            Console.WriteLine("Hello, " + PlayerOne.PlayerName + "! You have " + PlayerOne.PlayerHealth + " health.");
            Console.WriteLine("You will be represented as \"" + PlayerOne.PlayerToken + "\" on the screen.");
            Console.WriteLine("Use the arrow keys to navigate the map.");
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();

            Map.ImportMap();
            //Map.PrintMap();
            //Console.ReadKey();

            //Spawn player
            Map.sMap[Player.sPlayerRow][Player.sPlayerCol] = PlayerOne.PlayerToken;
            Map.RefreshMap(PlayerOne);

            while (ckInput != ConsoleKey.Escape)
            {
                ckInput = Console.ReadKey().Key;
                if (ConsoleKey.UpArrow == ckInput || ConsoleKey.DownArrow == ckInput || ConsoleKey.LeftArrow == ckInput || ConsoleKey.RightArrow == ckInput)
                {
                    Player.MovePlayer(ckInput, PlayerOne);
                }

            }
            if (ckInput == ConsoleKey.Escape)
            {
                Environment.Exit(0);
            }

            Console.ReadKey();
        }
    }
}
