using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsMakingAnagrams
{
    class Program
    {
        static int makeAnagram(string a, string b)
        {
            Dictionary<char, int> countAllChars1 = new Dictionary<char, int>();
            Dictionary<char, int> countAllChars2 = new Dictionary<char, int>();
            int iCharsToDelete = 0;
            foreach (char cChar in a)
            {
                if (countAllChars1.ContainsKey(cChar))
                {
                    countAllChars1[cChar]++;
                }
                else
                {
                    countAllChars1.Add(cChar, 1);
                }
                
            }

            foreach (char cChar in b)
            {
                if (countAllChars2.ContainsKey(cChar))
                {
                    countAllChars2[cChar]++;
                }
                else
                {
                    countAllChars2.Add(cChar, 1);
                }
                
            }

            char[] c = a.Intersect(b).ToArray();
            foreach (char cChar in c)
            {
                if (countAllChars1[cChar] >= countAllChars2[cChar])
                {
                    countAllChars1[cChar] = countAllChars1[cChar] - countAllChars2[cChar];
                    countAllChars2[cChar] = 0;
                }
                else
                {
                    countAllChars2[cChar] = countAllChars2[cChar] - countAllChars1[cChar];
                    countAllChars1[cChar] = 0;
                }
            }

            foreach (var x in countAllChars1)
            {
                iCharsToDelete += x.Value;
            }
            foreach (var x in countAllChars2)
            {
                iCharsToDelete += x.Value;
            }

            return iCharsToDelete;

        }
        static void Main(string[] args)
        {
            Console.WriteLine(makeAnagram("cde", "abc"));
            Console.ReadLine();
        }
    }
}
