using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalancedBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "{(([])[])[]}";

            Stack<char> newStack = new Stack<char>();

            foreach (char x in s)
            {
                if (x == '[' || x == '{' || x == '(')
                {
                newStack.Push(x);
                }else if (newStack.Count() == 0)
                {
                    Console.WriteLine("Fail!");
                    break;
                }
                else if (newStack.Peek() == '{' && x == '}' || newStack.Peek() == '[' && x == ']' || newStack.Peek() == '(' && x == ')')
                {
                    
                    newStack.Pop();
                }
                else
                {
                    Console.WriteLine("Fail!");
                    break;
                }

            }

            if (newStack.Count() != 0)
            {
                Console.WriteLine("FAIL!");
            }
            else
            {
                Console.WriteLine("PASS!");
            }



            Console.ReadKey();
        }
    }
}
