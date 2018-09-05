using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUD_v1
{
    class Player
    {
        private string sPlayerToken = "X";
        static public int sPlayerRow = 2;
        static public int sPlayerCol = 2;
        static private string sUnderlyingTile = "-";
        static public int[] sPlayerCoords = {0,0};
        private int sPlayerStartHP = 9;
        private int sPlayerCurrentHP;
        private string sPlayerName;

        //Constructors

        public Player()
        {
            sPlayerCurrentHP = sPlayerStartHP;
        }


        //Properties

        public int PlayerHealth
        {
            get
            {
                return sPlayerCurrentHP;
            }

            set
            {
                sPlayerCurrentHP += value;
            }
        }

        public string PlayerToken
        {
            get
            {
                return sPlayerToken;
            }
        }

        public string PlayerName
        {
            get
            {
                return sPlayerName;
            }

            set
            {
                sPlayerName = value;
            }
        }

        //Methods

        static public void MovePlayer(ConsoleKey ckDirection, Player pCurrentPlayer)
        {
            if (ConsoleKey.UpArrow == ckDirection)
            {
                if (Player.sPlayerRow > 0)
                {
                    //Replace player token with underlying map tile.
                    Map.sMap[Player.sPlayerRow][Player.sPlayerCol] = sUnderlyingTile;
                    //Save next map tile as underlying.
                    sUnderlyingTile = Map.sMap[Player.sPlayerRow - 1][Player.sPlayerCol];
                    //Move player token.
                    Map.sMap[Player.sPlayerRow -= 1][Player.sPlayerCol] = pCurrentPlayer.sPlayerToken;
                }
                else { }
            }
            else if (ConsoleKey.DownArrow == ckDirection)
            {
                if (Player.sPlayerRow < (Map.sMap.Count() - 1))
                {
                    Map.sMap[Player.sPlayerRow][Player.sPlayerCol] = sUnderlyingTile;
                    sUnderlyingTile = Map.sMap[Player.sPlayerRow + 1][Player.sPlayerCol];
                    Map.sMap[Player.sPlayerRow += 1][Player.sPlayerCol] = pCurrentPlayer.sPlayerToken;
                }
                else { }
            }
            else if (ConsoleKey.LeftArrow == ckDirection)
            {
                if (Player.sPlayerCol > 0)
                {
                    Map.sMap[Player.sPlayerRow][Player.sPlayerCol] = sUnderlyingTile;
                    sUnderlyingTile = Map.sMap[Player.sPlayerRow][Player.sPlayerCol - 1];
                    Map.sMap[Player.sPlayerRow][Player.sPlayerCol -= 1] = pCurrentPlayer.sPlayerToken;
                }
                else { }
            }
            else if (ConsoleKey.RightArrow == ckDirection)
            {
                if (Player.sPlayerCol < (Map.sMap[sPlayerRow].Count() - 1))
                {
                    Map.sMap[Player.sPlayerRow][Player.sPlayerCol] = sUnderlyingTile;
                    sUnderlyingTile = Map.sMap[Player.sPlayerRow][Player.sPlayerCol + 1];
                    Map.sMap[Player.sPlayerRow][Player.sPlayerCol += 1] = pCurrentPlayer.sPlayerToken;
                }
                else { }
            }
            if (sUnderlyingTile == "S")
            {
                Console.WriteLine("You found the shop!");
            }
            else
            {
                Map.RefreshMap(pCurrentPlayer);
            }

            sPlayerCoords[0] = sPlayerRow;
            sPlayerCoords[1] = sPlayerCol;
        }
    }
}
