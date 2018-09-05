using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6
{
    class Program
    {
        public static List<char> clHoldingKeep = new List<char>();
        public static List<char> clHoldingReplace = new List<char>();

        static void ExerciseOne()
        {
            List<int> lList = new List<int>() { 12, 5, 5, 1, 0, 2, 0, 12, 10 };

            int iMin = lList[0];
            int iMax = lList[0];

            Console.WriteLine("Original List:");
            foreach (int i in lList)
            {
                Console.WriteLine(i);
            }

            foreach (int i in lList)
            {
                if (i > iMax)
                {
                    iMax = i;
                }

                if (i < iMin)
                {
                    iMin = i;
                }
            }

            for (int i = lList.Count; i > 0; i--)
            {
                lList.Remove(iMin);
                lList.Remove(iMax);
            }

            Console.WriteLine("New List:");
            foreach (int i in lList)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
            Console.Clear();
            Menu();
        }

        static void ExerciseTwo()
        {
            string sOriginal = "aaaaa";
            string sSubstring = "ab";

            int iMatchStrings = 0;
            int iStartHere = 0;

            while (iStartHere < sOriginal.Length - (sSubstring.Length - 1))
            {
                if (TryToMatchString(iStartHere, sOriginal, sSubstring))
                {
                    //If string match found, add to count.
                    iMatchStrings++;
                    iStartHere++;
                }
                else
                {
                    //If not, try next in original.
                    iStartHere++;
                }
            }

            Console.WriteLine("Found {0} match(es)!", iMatchStrings);

            Console.ReadKey();
            Console.Clear();
            Menu();
        }

        static bool TryToMatchString(int _iStartHere, string _sOrig, string _sSub)
        {
            int iMatchLetters = 0;
            int iOrigInc = _iStartHere;

            //This loops a max of substring length, breaks when no match, breaks when finding a string match.
            for (int i = 0; i < _sSub.Length; i++)
            {
                //Do letters match?
                if (_sOrig[iOrigInc] == _sSub[i])
                {
                    iMatchLetters++;
                    //Does this match complete a string match?
                    if (iMatchLetters == _sSub.Length)
                    {
                        //Yes? Reset letter count, return complete match.
                        iMatchLetters = 0;
                        return true;
                    }
                    else
                    {
                        //No? Increment letter count and continue for loop.

                        iOrigInc++;
                    }
                }
                else
                {
                    //If letters don't match, return false.
                    return false;
                }
            }
            return false;
        }

        static void ExerciseThree()
        {
            Console.WriteLine("Enter a number:");
            int iInput = Convert.ToInt16(Console.ReadLine());
            int iRemainder = iInput;
            int x = 2;
            HashSet<int> hsDistinct = new HashSet<int>();
            List<int> iList = new List<int>();

            while (iRemainder > 1)
            {

                if (iRemainder % x == 0)
                {
                    iRemainder = iRemainder / x;
                    hsDistinct.Add(x);
                }
                else
                {
                    x++;
                }
            }

            foreach (int i in hsDistinct)
            {
                iList.Add(i);
            }

            foreach (int i in iList)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
            Console.Clear();
            Menu();
        }

        static void ExerciseFour()
        {
            string sOriginal = "Hello, I was looking for Han Solo.";
            string sSubstring = "lo";
            char cReplaceWith = '*';
            string sNew = "";
            Queue<char> qNew = new Queue<char>();
            
            int iMatchStrings = 0;
            int iStartHere = 0;
            int iNewInc = 0;

            while (iStartHere < sOriginal.Length - (sSubstring.Length - 1))
            {
                if (TryToFindString(iStartHere, sOriginal, sSubstring))
                {
                    //If string match found, add to count.
                    iMatchStrings++;
                    iStartHere += 2;
                }
                else
                {
                    //If not, try next in original.
                    qNew.Enqueue(sOriginal[iStartHere]);
                    iStartHere++;
                }
            }

            Console.WriteLine("Found {0} match(es)!", iMatchStrings);

            Console.WriteLine("To Keep:");
            foreach (char x in clHoldingKeep)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("To Replace:");
            foreach (char x in clHoldingReplace)
            {
                Console.WriteLine(x);
            }


            //Console.WriteLine(sNew);

            Console.ReadKey();
            Console.Clear();
            Menu();
        }

        static bool TryToFindString(int _iStartHere, string _sOrig, string _sSub)
        {
            int iMatchLetters = 0;
            int iOrigInc = _iStartHere;

            //This loops a max of substring length, breaks when no match, breaks when finding a string match.
            for (int i = 0; i < _sSub.Length; i++)
            {
                //Do letters match?
                if (SortLetters(_sOrig[iOrigInc], _sSub[i]))
                {
                    iMatchLetters++;
                    //Does this match complete a string match?
                    if (iMatchLetters == _sSub.Length)
                    {
                        //Yes? Reset letter count, return complete match.
                        iMatchLetters = 0;
                        return true;
                    }
                    else
                    {
                        //No? Increment letter count and continue for loop.

                        iOrigInc++;
                    }
                }
                else
                {
                    //If letters don't match, return false.
                    return false;
                }
            }
            return false;
        }

        static bool SortLetters(char cA, char cB)
        {
            if (cA == cB)
            {
                clHoldingReplace.Add(cA);
                return true;
            }
            else
            {
                clHoldingKeep.Add(cA);
                return false;
            }
        }

        static void Main(string[] args)
        {

            Menu();

            Console.ReadKey();
        }

        static void Menu()
        {
            Console.WriteLine("Select Exercise:");
            Console.WriteLine("1. Remove All Min/Max from List");
            Console.WriteLine("2. Count Substring");
            Console.WriteLine("3. List Distinct Prime Factors");
            Console.WriteLine("4. Find and Replace");
            Console.WriteLine("5.");
            MenuSelect(Console.ReadLine());
        }

        static void MenuSelect(string _sSelection)
        {
            switch (_sSelection.ToUpper())
            {
                case "1":
                case "one":
                    ExerciseOne();
                    break;
                case "2":
                case "two":
                    ExerciseTwo();
                    break;
                case "3":
                case "three":
                    ExerciseThree();
                    break;
                case "4":
                case "four":
                    ExerciseFour();
                    break;
                default:
                    Console.Clear();
                    Menu();
                    break;
            }
        }
    }
}

