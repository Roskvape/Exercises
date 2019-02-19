using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CommonChild
{
    class Program
    {
        static int iLongestMatch = 0;
        static int iCurrentIndex = 0;
        static int commonChild(string s1, string s2)
        {
            HashSet<char> hash1 = FindLetters(s1);
            HashSet<char> hash2 = FindLetters(s2);
            hash1.IntersectWith(hash2);

            s1 = RemoveUncommonLetters(s1, hash1);
            s2 = RemoveUncommonLetters(s2, hash1);

            GetLongestMatch(s1,s2);

            return iLongestMatch;
        }

        static HashSet<char> FindLetters(string str)
        {
            HashSet<char> hash = new HashSet<char>();

            foreach (char x in str)
            {
                hash.Add(x);
            }

            return hash;
        }

        static string RemoveUncommonLetters(string s1, HashSet<char> hashCommon)
        {
            Queue<char> qChar = new Queue<char>();

            foreach (char x in s1)
            {
                if (hashCommon.Contains(x))
                {
                    qChar.Enqueue(x);
                }
            }

            string str = String.Empty;

            foreach (char x in qChar)
            {
                str += x;
            }

            return str;
        }

        static void FindMatch(string s1, string s2, string currentPattern)
        {
            //Find match index
            Console.WriteLine("Index: " + iCurrentIndex);

            //Expand pattern by next index
            if (iCurrentIndex + currentPattern.Length >= s1.Length)
            {
                Console.WriteLine("Nahhhh, ran out of letters!");
            }
            else
            {
                string newPattern = currentPattern + s1[iCurrentIndex + currentPattern.Length];

                //Format pattern for regex
                string newPatternFormatted = FormatForRegex(newPattern);

                //Check pattern against string 2
                Match myMatch2 = Regex.Match(s2, newPatternFormatted);
                if (myMatch2.Success)
                {
                    Console.WriteLine("Found it!" + " " + newPattern + " " + newPatternFormatted);

                    if (newPattern.Length > iLongestMatch)
                    {
                        iLongestMatch = newPattern.Length;
                        Console.WriteLine("Updating longest match to " + iLongestMatch);
                    }

                    FindMatch(s1, s2, newPattern);
                }
                else
                {
                    Console.WriteLine("Nope!");
                }
            }

        }

        static void GetLongestMatch(string s1, string s2)
        {
            iCurrentIndex = 0;
            //Try pattern starting with every letter
            for (int i = 0; i < s1.Length; i++)
            {
                iCurrentIndex = i;
                FindMatch(s1, s2, Convert.ToString(s1[i]));
            }
        }

        static string FormatForRegex(string newPattern)
        {
            string newPatternFormatted = "";

            for (int i = 0; i < newPattern.Length; i++)
            {
                if (i != newPattern.Length - 1)
                {
                    newPatternFormatted += newPattern[i] + ".*";
                }
                else
                {
                    newPatternFormatted += newPattern[i];
                }
            }
            return newPatternFormatted;
        }

        static void Main(string[] args)
        {
            //Console.WriteLine(commonChild("WEWOUCUIDGCGTRMEZEPXZFEJWISRSBBSYXAYDFEJJDLEBVHHKS", "FDAGCXGKCTKWNECHMRXZWMLRYUCOCZHJRRJBOAJOQJZZVUYXIC"));
            Console.WriteLine(commonChild("applebutter", "aplebutter"));
            Console.ReadLine();
        }
    }
}
