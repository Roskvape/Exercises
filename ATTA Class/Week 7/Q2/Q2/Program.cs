using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;





namespace Q2
{
    class Program
    {
        static void Staircase(int n)
        {
            // Counter for how many spaces per line
            int spaces = n - 1;

            // Drawing loop: Outer loop for each line
            for (int j = 0; j < n; ++j)
            {
                // Inner loop draws individual characters
                for (int i = 0; i < n; ++i)
                {
                    if (i < spaces)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("#");
                    }
                    
                }
                // Adjust spaces...
                --spaces;
                // New line
                Console.Write("\n");
            }
        
        }

        static void Main(string[] args)
        {
            Staircase(5);
        }
    }
}
