using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUD_v1
{
    class Map
    {
        static public string[] sMapData = System.IO.File.ReadAllLines("MapData.txt");
        static public string[][] sMap = new string[sMapData.Count()][];

        static public void ImportMap()
        {
            int iMapReadIncrementer = 0;

            foreach (string s in sMapData)
            {
                sMap[iMapReadIncrementer] = s.Split(' ');
                iMapReadIncrementer++;
            }
        }

        static public void RefreshMap(Player pCurrentPlayer)
        {
            Console.Clear();
            PrintMap(pCurrentPlayer);
        }

        static public void PrintMap(Player pCurrentPlayer)
        {
            //Top border
            Console.Write(" " + '\u250C');
            for (int i = 0; i < ((sMap[0].Count()*2)+1); i++)
            {
                Console.Write('\u2500');
            }
            Console.Write('\u2510' + "\n");

            //Map with left and right borders
            for (int i = 0; i < sMap.Length; i++)
            {
                Console.Write(" " +'\u2502' + " ");
                for (int x = 0; x < sMap[i].Count(); x++)
                {
                    Console.Write(sMap[i][x] + " ");
                }
                Console.Write('\u2502' + "\n");
            }

            //Bottom border
            Console.Write(" " +'\u255E');
            for (int i = 0; i < ((sMap[0].Count() * 2) + 1); i++)
            {
                Console.Write('\u2500');
            }
            Console.Write('\u2561' + "\n");

            //Stats
            Console.Write(" " + '\u2502');
            for (int i = 0; i < (((sMap[0].Count()*2)-11) / 2); i++)
            {
                Console.Write(" ");
            }
            Console.Write($"{pCurrentPlayer.PlayerHealth}HP    9/9INV");
            for (int i = 0; i < (((sMap[0].Count() * 2) -11) / 2); i++)
            {
                Console.Write(" ");
            }
            Console.Write('\u2502' + "\n");


            //Messages
            Console.Write(" " + '\u255E');
            for (int i = 0; i < ((sMap[0].Count() * 2)+1); i++)
            {
                Console.Write('\u2550');
            }
            Console.Write('\u2561' + "\n");

        }

        //static public void PrintMapASCII()
        //{
        //    Console.Write(" ");
        //    for (int i = 0; i < ((sMap[0].Count() * 2) + 2); i++)
        //    {
        //        Console.Write("_");
        //    }
        //    Console.Write("\n");
        //    for (int i = 0; i < sMap.Length; i++)
        //    {
        //        Console.Write(" |");
        //        for (int x = 0; x < sMap[i].Count(); x++)
        //        {
        //            Console.Write(sMap[i][x] + " ");
        //        }
        //        Console.Write("|\n");
        //    }
        //    Console.Write(" ");
        //    for (int i = 0; i < ((sMap[0].Count() * 2) + 2); i++)
        //    {
        //        Console.Write("=");
        //    }
        //    Console.Write("\n");
        //}
    }
}
