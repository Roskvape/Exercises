using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk1_Functions_01
{
    class Program
    {
        static void Main()
        {
            string message = "Test String!";
            int iSumInput = 0;
            int iHealthInput = 100;
            int iDmgInput;
            int iEvenPosInput;
            int iPickFunction;
            
            
            //Exercise One
            Console.WriteLine("Exercise One");
            PrintString(message);
            PrintString2("Stay awhile and listen!");

            //Exercise Two
            Console.WriteLine("\n\nExercise Two");
            Console.WriteLine("What number to use for summation?");
            iSumInput = Convert.ToInt16(Console.ReadLine());
            Summation(iSumInput);

            //Exercise Three
            Console.WriteLine("\n\nExercise Three");
            Console.WriteLine("You have 100 hitpoints. How much damage do you take?");
            iDmgInput = Convert.ToInt16(Console.ReadLine());
            TakeDamage(iHealthInput, iDmgInput);
            
            //Exercise Four
            Console.WriteLine("\n\nExercise Four");
            Console.WriteLine("Enter any number:");
            iEvenPosInput = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Is it positive?\n" + IsItPositive(iEvenPosInput));
            Console.WriteLine("Is it even?\n" + IsItEven(iEvenPosInput));
            Console.WriteLine("Is it both positive and even?\n" + IsItPositivelyEven(iEvenPosInput));
            
            //Exercise Five
            Console.WriteLine("\n\nExercise Five");
            Console.WriteLine("Pick a number:");
            Console.WriteLine("1. Average of Three");
            Console.WriteLine("2. Equal and False");
            Console.WriteLine("3. Square of an Integer");
            Console.WriteLine("4. Concatenate Two Strings");
            Console.WriteLine("5. Hypotenuse");
            iPickFunction = Convert.ToInt16(Console.ReadLine());
            ChooseFunction(iPickFunction);



            
            //Console.ReadLine();

        }

        static void PrintString(string s)
        {
            Console.WriteLine(s);
            //Console.ReadLine();
        }
        static void PrintString2(string s)
        {
            Console.WriteLine(s);
            //Console.ReadLine();
        }

        static void Summation(int n)
        {
            Console.WriteLine("Summation is: " + n*(n+1)/2);
            //Console.ReadLine();
        }

        static void TakeDamage(int iHealth, int iDmg)
        {
            int iCurrentHealth = iHealth - iDmg;
            
            if (iCurrentHealth <= 0)
            {
                Console.WriteLine("You are dead.");
            }
            else
            {
                Console.WriteLine("You take " + iDmg + " damage.\nYou now have " + iCurrentHealth + " hitpoints.");
            }
            //Console.ReadLine();
        }

        static bool IsItPositive(int iSign)
        {
            bool bNeg = iSign > 0;
            return bNeg;
            //Console.WriteLine("Is it positive?\n" + bNeg);
            //Console.ReadLine();
        }

        static bool IsItEven(int iEvenOdd)
        {
            bool bEvenOdd = iEvenOdd%2==0;
            return bEvenOdd;
            //Console.WriteLine("Is it even?\n" + bEvenOdd);
            //Console.ReadLine();
        }
        
        static bool IsItPositivelyEven(int iEvenPos)
        {
            bool bEvenPos = IsItPositive(iEvenPos) == true && IsItEven(iEvenPos) == true;
            return bEvenPos;
            //Console.WriteLine("Is it both positive and even?\n" + bEvenPos);
            //Console.ReadLine();
        }
        
        static void ChooseFunction(int iFun)
        {

            switch (iFun)
            {
                case 1:
                    Console.WriteLine("\nYou've selected Function1.");
                    Console.ReadLine();
                    Function1();
                    break;
                case 2:
                    Console.WriteLine("\nYou've selected Function2.");
                    Console.ReadLine();
                    Function2();
                    break;
                case 3:
                    Console.WriteLine("\nYou've selected Function3.");
                    Console.ReadLine();
                    Function3();
                    break;
                case 4:
                    Console.WriteLine("\nYou've selected Function4.");
                    Console.ReadLine();
                    Function4();
                    break;
                case 5:
                    Console.WriteLine("\nYou've selected Function5.");
                    Console.ReadLine();
                    Function5();
                    break;
                default:
                    Console.WriteLine("Dunno why you're here. You picked: " + iFun);
                    break;
            }
            
        }
        static void Function1()
        {
            int i1;
            int i2;
            int i3;
            int iAvg;
            char cReturn = 'Y';

            Console.WriteLine("Pick three numbers to average.");
            i1 = Convert.ToInt16(Console.ReadLine());
            i2 = Convert.ToInt16(Console.ReadLine());
            i3 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("You chose {0}, {1}, and {2}.", i1, i2, i3);
            iAvg = (i1 + i2 + i3) / 3;
            Console.WriteLine("Average is: " + iAvg);

            Console.WriteLine("Return to Main menu? (Y/N)");
            cReturn = Convert.ToChar(Console.ReadLine());

            if ('Y' == cReturn || 'y' == cReturn)
            {
                Main();
            }
            else
            {
                Console.WriteLine("Buh-bye!");
                Console.ReadLine();
            }

        }

        static void Function2()
        {
            int i1;
            int i2;
            bool bEqual;
            char cReturn = 'Y';

            Console.WriteLine("Pick two numbers to compare.");
            i1 = Convert.ToInt16(Console.ReadLine());
            i2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("You chose {0}, and {1}.", i1, i2);
            bEqual = i1 == i2;
            Console.WriteLine("Are they equal? " + bEqual);

            Console.WriteLine("Return to Main menu? (Y/N)");
            cReturn = Convert.ToChar(Console.ReadLine());

            if ('Y' == cReturn || 'y' == cReturn)
            {
                Main();
            }
            else
            {
                Console.WriteLine("Buh-bye!");
                Console.ReadLine();
            }

        }

        static void Function3()
        {
            int i1;
            int iSquare;
            char cReturn = 'Y';

            Console.WriteLine("Pick a number to square.");
            i1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("You chose {0}.", i1);
            iSquare = i1 * i1;
            Console.WriteLine("The square of {0} is {1}.", i1, iSquare);

            Console.WriteLine("Return to Main menu? (Y/N)");
            cReturn = Convert.ToChar(Console.ReadLine());

            if ('Y' == cReturn || 'y' == cReturn)
            {
                Main();
            }
            else
            {
                Console.WriteLine("Buh-bye!");
                Console.ReadLine();
            }

        }

        static void Function4()
        {
            string s1;
            string s2;
            string sBoth;
            char cReturn = 'Y';

            Console.WriteLine("Say half of something.");
            s1 = Console.ReadLine();
            Console.WriteLine("Say the other half.");
            s2 = Console.ReadLine();
            sBoth = s1 + s2;
            Console.WriteLine("Together, both halves are:\n{0}", sBoth);
            
            Console.WriteLine("Return to Main menu? (Y/N)");
            cReturn = Convert.ToChar(Console.ReadLine());

            if ('Y' == cReturn || 'y' == cReturn)
            {
                Main();
            }
            else
            {
                Console.WriteLine("Buh-bye!");
                Console.ReadLine();
            }

        }

        static void Function5()
        {
            double d1;
            double d2;
            double dHypotenuse;
            char cReturn = 'Y';

            Console.WriteLine("Pick the lengths of two sides of a right triangle:");
            d1 = Convert.ToDouble(Console.ReadLine());
            d2 = Convert.ToDouble(Console.ReadLine());
            dHypotenuse = Math.Sqrt(d1*d1 + d2*d2);
            Console.WriteLine("The length of the hypotenuse is:\n{0}", dHypotenuse);

            Console.WriteLine("Return to Main menu? (Y/N)");
            cReturn = Convert.ToChar(Console.ReadLine());

            if ('Y' == cReturn || 'y' == cReturn)
            {
                Main();
            }
            else
            {
                Console.WriteLine("Buh-bye!");
                Console.ReadLine();
            }

        }

    }
}
