using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk4_ProblemSolving
{
    class Program
    {
        static void ExerciseOne()
        {
            int[] iArray = new int[50];

            for (int i = 0; i < 50; i++)
            {
                iArray[i] = (i+1)*5;
            }
            
            foreach (int x in iArray)
            {
                Console.Write(x + " ");
            }

            Console.ReadKey();
        }

        static void ExerciseTwo()
        {
            string[] sArray = new string[] {"", "a", "of", "and", "four", "peach" };

            for (int i = 0; i < sArray.Length; i++)
            {
                if (sArray[i].Length == 1)
                {
                    Console.WriteLine("\"" + sArray[i] + "\" is " + sArray[i].Length + " character long.");
                }
                 else
                {
                    Console.WriteLine("\"" + sArray[i] + "\" is " + sArray[i].Length + " characters long.");
                }
            }

            Console.ReadKey();
        }

        static void ExerciseThree()
        {
            string[] sArray = new string[] { "", "", "l", "a", "pork", "of", "and", "four", "peach", "poach", "patch" };

            List<string> sLongest = new List<string>(sArray.Length);

            sLongest.Add("");

            for (int i = 0; i < sArray.Length; i++)
            {
                if (sArray[i].Length > sLongest[0].Length)
                {
                    sLongest.Clear();
                    sLongest.Add(sArray[i]);
                }
                else if (sArray[i].Length == sLongest[0].Length)
                {
                    sLongest.Add(sArray[i]);
                }
                else
                {

                }
            }

            foreach (string x in sLongest)
            {
                Console.WriteLine(x);
            }

            Console.ReadKey();
        }

        static void ExerciseFour()
        {
            string sWord = "Apple";
            string sDrow = "";

            for (int i = 0; i < sWord.Length; i++)
            {
                sDrow += Convert.ToString(sWord[(sWord.Length - 1)- i]);
            }

            Console.WriteLine(sDrow);

            Console.ReadKey();
        }

        static void ExerciseFive()
        {
            int[,] iArray = new int[,] { { 0, 5 }, { 1,4 } };
            int iSum = 0;


                foreach (int x in iArray)
                {
                    iSum += x;
                }

            Console.WriteLine(iSum);

            Console.ReadKey();

        }

        static void ExerciseSix()
        {
            Student NewStudent = new Student("Joey Ray", 50f);

            Console.WriteLine("Add a grade:");
            NewStudent.AddGrade(Convert.ToSingle(Console.ReadLine()));

            Console.WriteLine(NewStudent.GradeAverage);

            Console.WriteLine(NewStudent.GPA);

            Console.ReadKey();
        }

        static void ExerciseEight()
        {
            List<int> iListAll = new List<int> { 1, 2, 3, 4, 5, 6, 7 };
            List<int> iListEven = new List<int>();

            foreach (int x in iListAll)
            {
                if (x % 2 == 0)
                {
                    iListEven.Add(x);
                }
            }

            Console.WriteLine("All:");
            foreach (int x in iListAll)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("Evens:");
            foreach (int x in iListEven)
            {
                Console.WriteLine(x);
            }

            Console.ReadKey();
        }

        static void ExerciseNine()
        {
            //int iInput = Convert.ToInt16(Console.ReadLine());

            //Console.WriteLine(iInput%2);

            List<int> iList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 8, 10, 7, 0 };
            for (int x = 0; x < iList.Count; x++)
            {
                Console.WriteLine(iList[x] + " has a modulous two of: " + (iList[x] % 2));
            }

            Console.WriteLine("All:");
            foreach (int x in iList)
            {
                Console.WriteLine(x);
            }

            for (int i = iList.Count - 1; i >= 0; i--)
            {
                if (iList[i] % 2 != 0)
                {

                    Console.WriteLine("i is " + i + " and " + iList[i] + " has a modulous two of: " + (iList[i] % 2));
                    iList.Remove(iList[i]);
                }
            }

            Console.WriteLine("Evens:");
            foreach (int x in iList)
            {
                Console.WriteLine(x);
            }

            Console.ReadKey();
        }

        static void ExerciseTen()
        {
            Console.WriteLine("Enter an offset:");
            int iOffset = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter a word:");
            string sInput = Console.ReadLine().ToLower();

            string sOutput = "";

            for (int i = 0; i < sInput.Length; i++)
            {
                if (sInput[i] + iOffset < 'a' && sInput[i] > '`')
                {
                    char cX = Convert.ToChar('{' + iOffset + (sInput[i] - 'a'));
                    Console.WriteLine(cX);
                    sOutput += cX;
                }
                else if (sInput[i] > '`' && sInput[i] <= ('z' - iOffset))
                {
                    char cX = Convert.ToChar(sInput[i] + iOffset);
                    Console.WriteLine(cX);

                    sOutput += cX;
                }
                else if (sInput[i] > ('z' - iOffset) && sInput[i] < '{')
                {
                    char cX = Convert.ToChar('`' + iOffset - ('z' - sInput[i]));
                    Console.WriteLine(cX);
                    sOutput += cX;
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }

            }

            Console.WriteLine(sOutput);

            Console.ReadKey();
        }

        static void ExerciseEleven()
        {
            List<string> sListInput = new List<string>();
            List<string> sListRemove = new List<string>();

            ConsoleKey ckInput = ConsoleKey.A;

            Console.WriteLine("Create a list. Press Escape when done.");

            while (ckInput != ConsoleKey.Escape)
            {
                Console.WriteLine("Enter next string:");

                sListInput.Add(Console.ReadLine());
                ckInput = Console.ReadKey().Key;
            }

            Console.WriteLine("\n");
            foreach (string sX in sListInput)
            {
                Console.WriteLine(sX);
            }

            Console.ReadKey();

            ckInput = ConsoleKey.A;

            Console.WriteLine("Now list things to remove. Press Escape when done.");

            while (ckInput != ConsoleKey.Escape)
            {
                Console.WriteLine("Enter next string:");

                sListRemove.Add(Console.ReadLine());
                ckInput = Console.ReadKey().Key;
            }

            Console.WriteLine("\n");
            foreach (string sX in sListRemove)
            {
                Console.WriteLine(sX);
            }

            Console.ReadKey();

            ExElevenFunction(sListInput, sListRemove);
        }

        static void ExElevenFunction(List<string> sFullList, List<string> sRemoveList)
        {
            foreach (string sX in sRemoveList)
            {
                sFullList.Remove(sX);
            }
            Console.WriteLine("\n");
            foreach (string sX in sFullList)
            {
                Console.WriteLine(sX);
            }

            Console.ReadKey();
        }

        static void ExerciseTwelve()
        {
            string sInput1 = "";
            string sInput2 = "";
            int iConsecutiveMatches = 0;
            bool bContains = false;

            Console.WriteLine("Give me a string:");
            sInput1 = Console.ReadLine();
            Console.WriteLine("Give me another string:");
            sInput2 = Console.ReadLine();
            Console.WriteLine("\n");

            for (int i = 0; i < (sInput1.Length - sInput2.Length + 1); i++)
            {

                for (int x = 0; x < sInput2.Length; x++)
                {
                    if (sInput1[i+x] == sInput2[x])
                    {
                        iConsecutiveMatches++;

                    }
                    else
                    {
                        iConsecutiveMatches = 0;
                        break;
                    }
                }
                 if (iConsecutiveMatches == sInput2.Length)
                {
                    bContains = true;
                    break;
                }
            }
            
            if (bContains == true)
            {
                Console.WriteLine("\"" + sInput1 + "\" contains \"" + sInput2 + "\"!");
            }
            else
            {
                Console.WriteLine("\"" + sInput1 + "\" does not contain \"" + sInput2 + "\"!");
            }
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Menu();
            Console.ReadKey();
        }

        static void Menu()
        {
            string sSelection;

            Console.WriteLine("Select an exercise to run:");
            Console.WriteLine("1. Array of 50");
            Console.WriteLine("2. Lengths of Strings in Array");
            Console.WriteLine("3. Longest String in Array");
            Console.WriteLine("4. Reverse a String");
            Console.WriteLine("5. Sum all in 2-D Array");
            Console.WriteLine("6. Student Class");
            Console.WriteLine("7. GPA");
            Console.WriteLine("8. List of Even Integers");
            Console.WriteLine("9. Remove Odd Integers from List");
            Console.WriteLine("10. Encryption");
            Console.WriteLine("11. Subtract Strings from List");
            Console.WriteLine("12. String Contains String?");

            sSelection = Console.ReadLine();
            MenuSelection(sSelection);
        }

        static void MenuSelection(string sInput)
        {
            switch (sInput.ToLower())
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
                    ExerciseSix();
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
                    break;
            }
        }
    }

    class Student
    {
        private string sStudentName = "";
        private List<float> sStudentGrades = new List<float>();

        //Constructor
        public Student(string sName, float fGrade)
        {
            sStudentName = sName;
            sStudentGrades.Add(fGrade);
        }

        //Methods
        public void AddGrade(float fNewGrade)
        {
            sStudentGrades.Add(fNewGrade);
        }

        public float GradeAverage
        {
            get
            {
                float fAvg = sStudentGrades.Average();
                return fAvg;
            }
        }

        public float GPA
        {
            get
            {
                float fGPA = sStudentGrades.Average()/25;

                if (sStudentGrades.Average() > 93)
                {
                    fGPA = 4.0f;
                    return fGPA;
                }
                else if (sStudentGrades.Average() > 63 && sStudentGrades.Average() < 94)
                {
                    fGPA = (sStudentGrades.Average()-63)*.1f + .7f;
                    return fGPA;
                }
                else if (sStudentGrades.Average() > 59 && sStudentGrades.Average() < 64)
                {
                    fGPA = (sStudentGrades.Average() - 59) * .175f;
                    return fGPA;
                }
                else
                {
                    fGPA = 0;
                    return fGPA;
                }
            }
        }

    }
}
