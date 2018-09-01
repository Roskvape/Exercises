using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session6
{
    class Program
    {
      
        static bool Palindrome(string s)
        {
            if (s.Length < 2) return true;
            int b = -1;
            int e = s.Length;
            do
            {
                ++b;
                --e;
                if (s[b] != s[e])
                {
                    return false;
                }
            } while (e - b > 1);

            return true;
        }

        static bool Palindrome2(string s)
        {
            if (s.Length < 2) return true;
            int b = 0;
            int e = s.Length - 1;
            while(true)
            {
                if (s[b] != s[e])
                {
                    return false;
                }
                if (e - b < 2)
                {
                    break;
                }
                ++b;
                --e;
            }
            return true;
        }

        static bool Palindrome3(string s)
        {
            Stack<char> stack = new Stack<char>();
            foreach(char c in s)
            {
                stack.Push(c);
            }
            string reverse = "";
            while(stack.Any())
            {
                reverse = reverse + stack.Pop();
            }
            return s == reverse;
        }

        static void RemoveMinMax(List<int> list)
        {
            // Find the minimum and maximum values in this list
            int min = list.Min();
            int max = list.Max();
            // Remove all istances of min and max
            while (list.Contains(min))
                list.Remove(min);
            while (list.Contains(max))
                list.Remove(max);
        }
        

        static void Main(string[] args)
        {
            
        }
    }
}
