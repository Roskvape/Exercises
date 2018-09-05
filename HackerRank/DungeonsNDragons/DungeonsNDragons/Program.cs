using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsNDragons
{
    class Program
    {
        static long minHealth(List<int> dungeon)
        {
            long lMinHealth = 0;

            long lMostConsecutiveDmg = 0;
            long lCurrentHealth = 0;

            for (int i = 0; i < dungeon.Count(); i++)
            {
                lCurrentHealth += dungeon[i];

                if (lCurrentHealth < lMostConsecutiveDmg)
                {
                    lMostConsecutiveDmg = lCurrentHealth;
                }
            }

            lMinHealth = Math.Abs(lMostConsecutiveDmg) + 1;

            return lMinHealth;
        }

        static void Main(string[] args)
        {
            List<int> Roman = new List<int> { -5, 4,-2,3,1, -1, -6, -1, 0, 5};

            Console.WriteLine(minHealth(Roman));

            Console.ReadKey();


        }
    }
}
