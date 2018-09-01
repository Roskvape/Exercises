using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk2_Functions_ControlFlow_02
{
    class Program
    {
        const float fCostPerWidget = 1.75f;
        const float fWidgetPrice = 4.15f;

        static void ExerciseOne()
        {
            float fOne;
            float fTwo;
            float fThree;

            Console.WriteLine("Enter three floats.");
            fOne = Convert.ToSingle(Console.ReadLine());
            fTwo = Convert.ToSingle(Console.ReadLine());
            fThree = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("All numbers are positive and non-zero? " + TriplePositive(fOne, fTwo, fThree));
            Console.ReadLine();
        }
        static bool TriplePositive (float a, float b, float c)
        {
            bool bIsPos = false;
            
            if (a > 0 && b > 0 && c > 0)
            {
                bIsPos = true;
            }
            return bIsPos;
        }

        static void ExerciseTwo()
        {
            char cInput1;
            char cInput2;
            char cInput3;

            Console.WriteLine("Enter three characters.");
            cInput1 = Convert.ToChar(Console.ReadLine());
            cInput2 = Convert.ToChar(Console.ReadLine());
            cInput3 = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Sorted by alphabetical order: ");
            Console.WriteLine(Alphabetize(cInput1, cInput2, cInput3));

        }

        static string Alphabetize(char cA, char cB, char cC)
        {
            string sAlpha;
            char cFirst;
            char cMiddle;
            char cLast;

            if (cA < cB && cA < cC)
            {
                cFirst = cA;
                if (cB < cC)
                {
                    cMiddle = cB;
                    cLast = cC;
                }
                else
                {
                    cMiddle = cC;
                    cLast = cB;
                }
            }
            else if (cA > cB && cA > cC)
            {
                cLast = cA;
                if (cB < cC)
                {
                    cFirst = cB;
                    cMiddle = cC;
                }
                else
                {
                    cFirst = cC;
                    cMiddle = cB;
                }
            }
            else if(cA < cB && cA > cC)
            {
                cMiddle = cA;
                if (cB < cC)
                {
                    cFirst = cB;
                    cLast = cC;
                }
                else
                {
                    cFirst = cC;
                    cLast = cB;
                }
            }
            else if (cB < cC)
            {
                cFirst = cB;
                cMiddle = cA;
                cLast = cC;
            }
            else
            {
                cFirst = cC;
                cMiddle = cA;
                cLast = cB;
            }
            
            sAlpha = $"{cFirst}{cMiddle}{cLast}";
            //sAlpha = " " + cC + cB + cA;
            //sAlpha = cC + cB + cA;

            return sAlpha;
        }

        static void ExerciseThree()
        {
            for (int x = 0; x < 5; ++x)
            {
                for (int i = 1; i <= 10; ++i)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }

        static void ExerciseFour()
        {
            float fFirstSide;
            float fSecondSide;
            float fArea;

            Console.WriteLine("Enter the length (inches) of the first side:");
            fFirstSide = Convert.ToSingle(Console.ReadLine());

            if (fFirstSide <= 0)
            {
                Console.WriteLine("Invalid input. Must be non-zero, positive number.");
                ExerciseFour();
            }
            else
            {
                Console.WriteLine("Enter the length (inches) of the second side:");
                fSecondSide = Convert.ToSingle(Console.ReadLine());

                if (fSecondSide <= 0)
                {
                    Console.WriteLine("Invalid input. Must be non-zero, positive number.");
                    ExerciseFour();
                }
                else
                {

                    fArea = fFirstSide * fSecondSide;

                    Console.WriteLine("The area is " + fArea + " square inches.");
                }
            }
        }

        static void ExerciseFive()
        {
            const float fPi = 3.14f;
            float fCircleRadius;
            float fCircleArea;

            Console.WriteLine("Enter the radius (inches) of the circle:");
            fCircleRadius = Convert.ToSingle(Console.ReadLine());

            if (fCircleRadius <= 0)
            {
                Console.WriteLine("Invalid input. Must be non-zero, positive number.");
                ExerciseFive();
            }
            else
            {
                fCircleArea = fCircleRadius * fCircleRadius * fPi;
                Console.WriteLine("The area is " + fCircleArea + " square inches.");
            }
        }

        static void ExerciseSix()
        {
            string sMsg;
            char cDeco;
            int iMsgCount;

            Console.WriteLine("Enter your message:");
            sMsg = Console.ReadLine();
            Console.WriteLine("Enter your decorative symbol:");
            cDeco = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter how many times to repeat message:");
            iMsgCount = Convert.ToInt16(Console.ReadLine());

            PrintWithDecoration(sMsg, cDeco, iMsgCount);

        }

        static void PrintWithDecoration(string message, char ornament, int count)
        {
            for (int x = 0; x < count; x++)
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.Write(ornament);
                }

                Console.Write(message);

                for (int i = 0; i < 5; i++)
                {
                    Console.Write(ornament);
                }

                Console.Write("\n");
            }
        }

        static void ExerciseSeven()
        {
            int iStartRange;
            int iEndRange;
            int iFirstOccurence = 0;
            bool bFound = false;

            Console.WriteLine("Select start of the range:");
            iStartRange = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Select end of the range:");
            iEndRange = Convert.ToInt16(Console.ReadLine());

            for (int i = iStartRange; i < iEndRange; i++)
            {
                if (i%7 == 0 && i%2 != 0)
                {
                    iFirstOccurence = i;
                    bFound = true;
                    break;
                }
            }

            if (bFound == true)
            {
            Console.WriteLine("First occurring odd number that is divisible by seven is: " + iFirstOccurence);
            Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Not found.");
                Console.ReadLine();
            }
        }

        static void ExerciseEight()
        {
            int iDesiredWidgets;
            int iWidgetsSold;
            float fDesiredProfit;
            string sUserChoice;

            Console.WriteLine("Select an Option:");
            Console.WriteLine("1. Calculate cost of widget production.");
            Console.WriteLine("2. Calculate profit of widget sales.");
            Console.WriteLine("3. Calculate widgets needed for desired profit.");
            sUserChoice = Console.ReadLine();

            switch (sUserChoice.ToLower())
            {
                case "1":
                case "one":
                    Console.WriteLine("How many widgets would you like to manufacture?");
                    iDesiredWidgets = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Price to manufacture that many widgets: " + TotalCost(iDesiredWidgets));
                    break;
                case "2":
                case "two":
                    Console.WriteLine("How many widgets are sold?");
                    iWidgetsSold = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("That number of widgets sales will yield this much profit: " + GrossProfit(iWidgetsSold));
                    break;
                case "3":
                case "three":
                    Console.WriteLine("What is the target profit?");
                    fDesiredProfit = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine("Number of widget sales required for target profits: " + RequiredWidgets(fDesiredProfit));
                    break;
            }

        }

        static float TotalCost(int iWidgets)
        {

            float fTotalCost;

            fTotalCost = fCostPerWidget * iWidgets;

            return fTotalCost;
        }

        static float GrossProfit(int iSold)
        {
            float fProfit;
            float fTotalProfit;

            fProfit = fWidgetPrice - fCostPerWidget;
            fTotalProfit = fProfit * iSold;
            return fTotalProfit;

        }

        static int RequiredWidgets(float fTargetProfits)
        {
            int iRequiredWidgets = 0;
            float fProfits = 0f;

            fProfits = fWidgetPrice - fCostPerWidget;

            while (fProfits*iRequiredWidgets < fTargetProfits)
            {
                iRequiredWidgets++;
            }

            return iRequiredWidgets;
        }

        static void ExerciseNine()
        {
            int iMax;
            int iFib1 = 0;
            int iFib2 = 1;
            int iFibNext;

            Console.WriteLine("Enter a maximum number:");
            iMax = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Starting with seed values 0 and 1:");
            Console.Write(iFib1 + " ");
            Console.Write(iFib2 + " ");

            while (iFib2 < iMax)
            {
                iFibNext = iFib1 + iFib2;
                iFib1 = iFib2;
                iFib2 = iFibNext;
                Console.Write(iFibNext + " ");
            }


        }

        static void Menu()
        {
            string sChoice;

            Console.WriteLine("Which exercise would you like to run?");
            Console.WriteLine("1. Triple Positive Floats");
            Console.WriteLine("2. Alphabetize Three Characters");
            Console.WriteLine("3. Print 1-10 Five Times");
            Console.WriteLine("4. Area of a Rectangle With Error Handling");
            Console.WriteLine("5. Area of a Circle");
            Console.WriteLine("6. Message with Decorations, Repeated");
            Console.WriteLine("7. First Odd Number Divisible by Seven");
            Console.WriteLine("8. Widget Shop");
            Console.WriteLine("9. Fibonacci");

            sChoice = Console.ReadLine();

            switch (sChoice.ToLower())
            {
                case "one":
                case "1":
                    Console.WriteLine("You chose Ex. One: " + sChoice);
                    ExerciseOne();
                    Console.ReadLine();
                    break;
                case "two":
                case "2":
                    Console.WriteLine("You chose Ex. Two: " + sChoice);
                    ExerciseTwo();
                    Console.ReadLine();
                    break;
                case "three":
                case "3":
                    Console.WriteLine("You chose Ex. Three: " + sChoice);
                    ExerciseThree();
                    Console.ReadLine();
                    break;
                case "four":
                case "4":
                    Console.WriteLine("You chose Ex. Four: " + sChoice);
                    ExerciseFour();
                    Console.ReadLine();
                    break;
                case "five":
                case "5":
                    Console.WriteLine("You chose Ex. Five: " + sChoice);
                    ExerciseFive();
                    Console.ReadLine();
                    break;
                case "six":
                case "6":
                    Console.WriteLine("You chose Ex. Six: " + sChoice);
                    ExerciseSix();
                    Console.ReadLine();
                    break;
                case "seven":
                case "7":
                    Console.WriteLine("You chose Ex. Seven: " + sChoice);
                    ExerciseSeven();
                    Console.ReadLine();
                    break;
                case "eight":
                case "8":
                    Console.WriteLine("You chose Ex. Eight: " + sChoice);
                    ExerciseEight();
                    Console.ReadLine();
                    break;
                case "nine":
                case "9":
                    Console.WriteLine("You chose Ex. Nine: " + sChoice);
                    ExerciseNine();
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Invalid response, try again.\n\n");
                    Menu();
                    break;

            }
        }

        static void Main(string[] args)
        {

            Menu();

            
        }
    }
}
