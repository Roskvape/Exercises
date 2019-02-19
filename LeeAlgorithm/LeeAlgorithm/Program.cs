using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeeAlgorithm
{
    class Program
    {
        public static int[,] mazeArray =
        {
            {1, 1, 1, 1, 1, 0, 0, 1, 1, 1},
            {0, 1, 1, 1, 1, 1, 0, 1, 0, 1},
            {0, 0, 1, 0, 1, 1, 1, 0, 0, 1},
            {1, 0, 1, 1, 1, 0, 1, 1, 0, 1},
            {0, 0, 0, 1, 0, 0, 0, 1, 0, 1},
            {1, 0, 1, 1, 1, 0, 0, 1, 1, 0},
            {0, 0, 0, 0, 1, 0, 0, 1, 0, 1},
            {0, 1, 1, 1, 1, 1, 1, 1, 0, 0},
            {1, 1, 1, 1, 1, 0, 0, 1, 1, 1},
            {0, 0, 1, 0, 0, 1, 1, 0, 0, 1}
        };

        struct Node
        {
            public int x;
            public int y;
            public int dist;

            public Node(int row, int col, int dist)
            {
                x = row;
                y = col;
                this.dist = dist;
            }
        }

        public static int[] row = {-1, 0, 0, 1};
        public static int[] col = {0, -1, 1, 0};

        static bool IsValid(int[,] mazeArray, bool[,] visited, int row, int col)
        {
            return row >= 0 && row < 10 && //Boundary check for row
                   col >= 0 && col < 10 && //Boundary check for col
                   mazeArray[row, col] == 1 && //Is passable square in maze (1, not 0)
                   visited[row, col] != true; //Isn't already visited
        }

        static void BreadthFirstSearch(int[,] mazeArray, int startRow, int startCol, int targetRow, int targetCol)
        {
            bool[,] visitedArray = new bool[10,10]; //Bools default to false, so nowhere is visited yet

            Queue<Node> q = new Queue<Node>();

            visitedArray[startRow, startCol] = true;
            q.Enqueue(new Node(startRow, startCol, 0));

            int minDist = Int32.MaxValue;

            while (q.Any())
            {
                Node node = q.Dequeue();

                int nodeRow = node.x;
                int nodeCol = node.y;
                int nodeDist = node.dist;

                if (nodeRow == targetRow && nodeCol == targetCol)
                {
                    minDist = nodeDist;
                    break;
                }

                for (int k = 0; k < 4; k++)
                {
                    if (IsValid(mazeArray, visitedArray, nodeRow + row[k], nodeCol + col[k]))
                    {
                        visitedArray[nodeRow + row[k], nodeCol + col[k]] = true;
                        q.Enqueue(new Node(nodeRow + row[k], nodeCol + col[k], nodeDist + 1));
                        //Console.WriteLine("Visited " + (nodeRow + row[k]) + ", " + (nodeCol + col[k]) + " with a dist of " + (nodeDist + 1));
                    }
                }
            }

            if (minDist != Int32.MaxValue)
            {
                Console.WriteLine("The shortest path from start to end of maze: " + minDist);
            }
            else
            {
                Console.WriteLine("No possible path from start to end of maze.");
            }

            //Console.WriteLine("\nMap of visited locations:\n");
            //for (int row = 0; row < 10; row++)
            //{
            //    for (int col = 0; col < 10; col++)
            //    {
            //        Console.Write(visitedArray[row,col] + ", ");
            //    }

            //    Console.WriteLine();
            //}

        }

        static void Main(string[] args)
        {

            BreadthFirstSearch(mazeArray, 0, 0, 7, 5);

            Console.ReadLine();

        }
    }
}
