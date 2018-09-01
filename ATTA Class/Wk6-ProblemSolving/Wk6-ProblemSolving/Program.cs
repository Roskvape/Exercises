using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk6_ProblemSolving
{
    class Program
    {
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

            while (iStartHere < sOriginal.Length - (sSubstring.Length -1))
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

        static bool TryToMatchString(int _iStartHere,string _sOrig, string _sSub)
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

                if (iRemainder%x == 0)
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
            string sOriginal = "I am smitten.";
            string sReplace = "sm";
            char cReplaceWith = 'k';
            string sNew = "";

            Console.WriteLine(sOriginal + "\n");

            for (int i = 0; i < sOriginal.Length; i++)
            {
                if (sOriginal[i] == sReplace[0] && sOriginal[i+1] == sReplace[1])
                {
                    sNew = sNew + cReplaceWith;
                    i++;
                }
                else
                {
                    sNew = sNew + sOriginal[i];
                }
            }
            

            Console.WriteLine(sNew);

            Console.ReadKey();
            Console.Clear();
            Menu();
        }

        static void ExerciseFive()
        {
            int n = 10; //1 2 3 5 7
            List<int> lList = new List<int>();

            for (int i = 2; i <= n; i++)
            {
                if (IsPrime(i))
                {
                    lList.Add(i);
                    Console.WriteLine("yep");
                }
                else
                {
                    Console.WriteLine("nope");
                }
            }

            Console.WriteLine("All prime numbers in : " + n);

            foreach (int i in lList)
            {
                Console.WriteLine(i);
            }
        }

        static bool IsPrime(int iInput)
        {
            for (int x = 2; x <= iInput; x++)
            {
                if (iInput % x == 0 && x != iInput)
                {
                    return false;
                }
                else if(x == iInput)
                {
                    return true;
                }
            }
            return false;
        }

        static void ExerciseSix()
        {
            string sInput = "The quick brown fox jumps over the lazy dog…";
            string sOutput = "";
            string sAlphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            HashSet<char> cHash = new HashSet<char>();
            List<char> cList = new List<char>();

            foreach (char cAlpha in sAlphabet)
            {
                foreach (char cInput in sInput.ToUpper())
                {
                    if (cAlpha == cInput)
                    {
                        cList.Add(cInput);
                        break;
                    }
                }
            }

            foreach (char x in cList)
            {
                sOutput = sOutput + x;
            }

            Console.WriteLine("Original: \n" + sInput);
            Console.WriteLine("Output: \n" + sOutput);

            Console.ReadKey();
            Console.Clear();
            Menu();
        }

        static void ExerciseSeven()
        {
            int iFib1 = 0;
            int iFib2 = 1;
            int iLast = 0;
            int iInput = 0;
            List<int> lFibs = new List<int>();

            Console.WriteLine("Enter a number:");
            iInput = Convert.ToInt16(Console.ReadLine());

            while (iLast < iInput)
            {
                iLast = iFib1 + iFib2;
                lFibs.Add(iLast);
                iFib1 = iFib2;
                iFib2 = iLast;
            }

            if (lFibs.Last() == iInput)
            {
                Console.WriteLine("It's a Fibonacci!");
            }
            else
            {
                Console.WriteLine("It's not a Fibonacci.");
            }

            Console.ReadKey();
            Console.Clear();
            Menu();
        }

        static void ExerciseEight()
        {
            string s1 = "Apple";
            string s2 = "Bread";
            string sOutput = "";

            for (int i = 0; i < s1.Length; i++)
            {
                sOutput = sOutput + s1[i];
                sOutput = sOutput + s2[i];
            }

            Console.WriteLine(sOutput);

            Console.ReadKey();
            Console.Clear();
            Menu();
        }

        static void ExerciseNine()
        {
            List<float> lInput = new List<float>() { 1.5f, 7.92f, -5.1f, 2.7f };
            List<int> lOutput = new List<int>();

            lInput.Sort();

            for (int i = lInput.Count()-1; i >= 0; i--)
            {
                lOutput.Add(Convert.ToInt32(Math.Round(Convert.ToDecimal(lInput[i]), MidpointRounding.AwayFromZero)));
            }

            foreach (int i in lOutput)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
            Console.Clear();
            Menu();
        }

        static void ExerciseTen()
        {
            List<int> lInput = new List<int>() { 1, 2, 3, 7, 5, 3, 2, 8, 10, 13, 2, 1,0,-1 };
            bool bChanges = true;
            while (bChanges == true)
            {
                for (int i = 1; i < lInput.Count(); i++)
                {
                    bChanges = false;
                    if (lInput[i - 1] > lInput[i])
                    {
                        int iTemp = lInput[i - 1];
                        lInput[i - 1] = lInput[i];
                        lInput[i] = iTemp;
                        bChanges = true;
                        break;
                    }
                }
            }

            Console.WriteLine("Sorted list:");
            foreach ( int i in lInput)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
            Console.Clear();
            Menu();
        }

        static void ExerciseEleven()
        {
            List<int> lInput = new List<int>() { 1, 2, 3, 7, 5, 3, 2, 8, 10, 13, 2, 1, 0, -1 };
            int i = 1;
            while (i < lInput.Count())
            {
                int j = i;
                while (j > 0 && lInput[j-1] > lInput[j])
                {
                    int iTemp = lInput[j];
                    lInput[j] = lInput[j - 1];
                    lInput[j - 1] = iTemp;
                    j--;
                }
                i++;
            }

            Console.WriteLine("Sorted list:");
            foreach (int x in lInput)
            {
                Console.WriteLine(x);
            }

            Console.ReadKey();
            Console.Clear();
            Menu();
        }

        static void ExerciseTwelve()
        {
            List<int> lInput = new List<int>() { 1, 2, 3, 7, 5, 3, 2, 8, 10, 13, 2, 1, 0, -1, -3 };
            List<int> lOutput = new List<int>();

            Console.WriteLine("Orignal List:");
            foreach (int x in lInput)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("Final List:");

            lOutput = MergeSort(lInput);

            foreach (int x in lOutput)
            {
                Console.WriteLine(x);
            }

            Console.ReadKey();
            Console.Clear();
            Menu();
        }

        static List<int> MergeSort (List<int> _iInput)
        {
            List<int> lLeft = new List<int>();
            List<int> lRight = new List<int>();

            if (_iInput.Count <= 1)
            {
                return _iInput;
            }


            for (int i = 0; i < _iInput.Count(); i++)
            {
                if (i < _iInput.Count() / 2)
                {
                    lLeft.Add(_iInput[i]);
                }
                else
                {
                    lRight.Add(_iInput[i]);
                }
            }

            lLeft = MergeSort(lLeft);
            lRight = MergeSort(lRight);

            return MergeList(lLeft,lRight);
        }

        static List<int> MergeList (List<int> _iListLeft, List<int> _iListRight)
        {
            List<int> lMerged = new List<int>();

            while (_iListLeft.Count() != 0 && _iListRight.Count() != 0)
            {
                if (_iListLeft[0] < _iListRight[0])
                {
                    lMerged.Add(_iListLeft[0]);
                    _iListLeft.RemoveAt(0);
                }
                else
                {
                    lMerged.Add(_iListRight[0]);
                    _iListRight.RemoveAt(0);
                }
            }

            while (_iListLeft.Count() != 0)
            {
                lMerged.Add(_iListLeft[0]);
                _iListLeft.RemoveAt(0);
            }

            while (_iListRight.Count() != 0)
            {
                lMerged.Add(_iListRight[0]);
                _iListRight.RemoveAt(0);
            }

            return lMerged;
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
            Console.WriteLine("5. Find All Prime Numbers");
            Console.WriteLine("6. String Cleaning");
            Console.WriteLine("7. Is It Fibonacci?");
            Console.WriteLine("8. Interleaving Strings");
            Console.WriteLine("9. Round and Sort List");
            Console.WriteLine("10. Insertion Sort");
            Console.WriteLine("11. Insertion Sort Textbook");
            Console.WriteLine("12. Merge Sort");
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
                case "5":
                case "five":
                    ExerciseFive();
                    break;
                case "6":
                case "six":
                    ExerciseSix();
                    break;
                case "7":
                case "seven":
                    ExerciseSeven();
                    break;
                case "8":
                case "eight":
                    ExerciseEight();
                    break;
                case "9":
                case "nine":
                    ExerciseNine();
                    break;
                case "10":
                case "ten":
                    ExerciseTen();
                    break;
                case "11":
                case "eleven":
                    ExerciseEleven();
                    break;
                case "12":
                case "twelve":
                    ExerciseTwelve();
                    break;
                default:
                    Console.Clear();
                    Menu();
                    break;
            }
        }
    }
}
