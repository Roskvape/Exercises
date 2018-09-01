using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RansomNote
{
    class Program
    {
        //static void checkMagazine(string[] magazine, string[] note)
        //{
        //    int iMatches = 0;

        //    foreach (string sCurrent in note)
        //    {
        //        for (int iMag = 0; iMag < magazine.Length; iMag++)
        //        {
        //            if (sCurrent == magazine[iMag])
        //            {
        //                iMatches++;
        //                magazine[iMag] = "";
        //                break;
        //            }
        //        }

        //        if (iMatches == note.Length)
        //        {
        //            Console.WriteLine("Yes");
        //            break;
        //        }
        //    }

        //    if (iMatches < note.Length)
        //    {
        //        Console.WriteLine("No"); 
        //    }
        //}

        static void checkMagazine(string[] magazine, string[] note)
        {
            Hashtable hashMag = new Hashtable();
            int iMatches = 0;


            for (int iMag = 0; iMag < magazine.Length; iMag++)
            {

                if (hashMag.ContainsKey(magazine[iMag]))
                {
                    int iCount = (int)hashMag[magazine[iMag]];
                    iCount++;
                    hashMag[magazine[iMag]] = iCount;
                }
                else
                {
                    hashMag.Add(magazine[iMag], 1);
                }
            }

            //foreach (DictionaryEntry x in hashMag)
            //{
            //    Console.WriteLine(x.Key + " , " + x.Value);
            //}

            //Console.WriteLine("\nNote requires:\n");
            //foreach (string sNote in note)
            //{
            //    Console.Write(sNote + " ");
            //}
            //Console.WriteLine("\n");

            foreach (string sNote in note)
            {
                if (hashMag.ContainsKey(sNote))
                {
                    //Console.WriteLine("Match found for " + sNote);
                    int iCount = (int)hashMag[sNote];

                    if (iCount == 0)
                    {
                        Console.WriteLine("No");
                        break;
                    }

                    iMatches++;
                    iCount--;
                    hashMag[sNote] = iCount;
                }
                else
                {
                    Console.WriteLine("No");
                }
            }

            if (iMatches == note.Length)
            {
                Console.WriteLine("Yes");
            }

            //Console.WriteLine("Updated hash:");
            //foreach (DictionaryEntry x in hashMag)
            //{
            //    Console.WriteLine(x.Key + " , " + x.Value);
            //}

            //if (hashMag.ContainsValue("apple"))
            //{
            //    iMatches++;
            //    int iValue = (string)hashMag["apple"];
            //    hashMag.Remove(iValue);
            //    Console.WriteLine("Found it!");
            //}

            //Console.WriteLine("After removal");
            //foreach (DictionaryEntry x in hashMag)
            //{
            //    Console.WriteLine(x.Value);
            //}

        }

        static void Main(string[] args)
        {
            string[] sMagazine1 = new string[] { "doctor", "An", "doctor", "apple", "a", "day", "keeps", "the", "doctor", "away" };
            string[] sNote1 = new string[] { "a", "day", "keeps", "the", "doctor" };

            string[] sMagazine2 = new string[] { "An", "apple", "a", "day", "keeps", "the", "doctor", "away" };
            string[] sNote2 = new string[] { "an", "apple", "keeps", "the", "doctor" };

            string[] sMagazine3 = new string[] { "An", "apple", "a", "day", "keeps", "the", "doctor", "away" };
            string[] sNote3 = new string[] { "a", "day", "keeps", "a", "doctor" };


            Console.WriteLine("\n");
            checkMagazine(sMagazine1, sNote1);
            Console.WriteLine("\n");
            checkMagazine(sMagazine2, sNote2);
            Console.WriteLine("\n");
            checkMagazine(sMagazine3, sNote3);
            Console.WriteLine("\n");

            Console.ReadKey();
        }
    }
}
