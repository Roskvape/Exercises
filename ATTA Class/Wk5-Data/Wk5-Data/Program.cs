using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk5_Data
{
    
    struct Person
    {
        public string sName;
        public uint uiAge;

        Person(string _sName, uint _uiAge)
        {
            sName = _sName;
            uiAge = _uiAge;
        }
    }

    struct BlizzardFan
    {
        public string sName;
        public uint uiAge;
        public bool hasTicket;

        BlizzardFan(string _sName, uint _uiAge, bool _bTicket)
        {
            sName = _sName;
            uiAge = _uiAge;
            hasTicket = _bTicket;
        }
    }

    class Program
    {
        static PersonQueue pqClass = new PersonQueue();
        static TicketVendor tvBlizzCon2018 = new TicketVendor();
        static void ExerciseOne()
        {

            bool bQueueEmpty = false;
            ConsoleKey ckInput = ConsoleKey.A;

            while (ConsoleKey.Escape != ckInput)
            {
                PopulateQueue();
                ckInput = Console.ReadKey().Key;
            }
            if (ConsoleKey.Escape == ckInput)
            {
                Console.Clear();
            }

            while (false == bQueueEmpty)
            {
                try
                {
                    Person pCurrent;
                    pCurrent = pqClass.PullPerson();
                    Console.WriteLine("{0}, {1}", pCurrent.sName, pCurrent.uiAge);
                }
                catch (InvalidOperationException e)
                {
                    //Console.WriteLine("Queue is empty.");
                    bQueueEmpty = true;
                }
            }

            Console.ReadKey();
            Console.Clear();
            Menu();
        }

        static void PopulateQueue()
        {

            Person pNew = new Person();
            bool bTryAgain = true;

            Console.WriteLine("Enter name:");
            pNew.sName = Console.ReadLine();


            while (true == bTryAgain)
            {
                Console.WriteLine("Enter age:");
                string sInput = Console.ReadLine();
                if (true == uint.TryParse(sInput, out pNew.uiAge))
                {
                    Console.WriteLine("Success! " + pNew.uiAge + " is a number!");
                    bTryAgain = false;
                }
                else
                {
                    Console.WriteLine("That's not a number! Try again!");
                }
            }

            pqClass.AddPerson(pNew);
            
            Console.WriteLine("\nPress any key to continue or Escape to exit.");
        }

        static void ExerciseTwo()
        {
            Console.WriteLine("Enter a string:");
            string sInput = Console.ReadLine();

            Console.WriteLine(Encrypt(sInput));
        }

        static string Encrypt(string _sEncryptMe)
        {
            string sEncrypted = "";
            Stack<Int32> sIntStack = new Stack<Int32>();

            foreach (char x in _sEncryptMe)
            {
                sIntStack.Push(Convert.ToInt32(x)-1);
            }
            
            for (int i = sIntStack.Count(); i > 0; i--)
            {
                sEncrypted += Convert.ToChar(sIntStack.Pop());
            }

            return sEncrypted;
        }

        static void ExerciseThree()
        {
            Console.WriteLine("Enter a string:");
            string sInput = Console.ReadLine();

            Console.WriteLine(Decrypt(sInput));
        }

        static string Decrypt(string _sDecryptMe)
        {
            string sDecrypted = "";
            Stack<Int32> sIntStack = new Stack<Int32>();

            foreach (char x in _sDecryptMe)
            {
                sIntStack.Push(Convert.ToInt32(x) +1);
            }

            for (int i = sIntStack.Count(); i > 0; i--)
            {
                sDecrypted += Convert.ToChar(sIntStack.Pop());
            }

            return sDecrypted;
        }

        static void ExerciseFour()
        {
            List<string> lStringList = new List<string>();
            HashSet<string> hsStringHashed = new HashSet<string>();

            lStringList.Add("Zebra");
            lStringList.Add("Cow");
            lStringList.Add("Apple");
            lStringList.Add("Apple");
            lStringList.Add("Cow");
            lStringList.Add("Apple");

            foreach (string s in lStringList)
            {
                hsStringHashed.Add(s);
            }

            lStringList.Clear();

            foreach (string s in hsStringHashed)
            {
                lStringList.Add(s);
            }

            lStringList.Sort();

            foreach (string s in lStringList)
            {
                Console.WriteLine(s);
            }

            Console.ReadKey();

        }

        static void ExerciseFive()
        {
            string sHashMe = "";
            int iSum = 0;

            sHashMe = Console.ReadLine();

            foreach (char c in sHashMe)
            {
                iSum += c;
            }

            iSum = iSum % 100;

            Console.WriteLine(iSum);
        }
        
        static void ExerciseSix()
        {
            Dictionary<string,int> dIntString = new Dictionary<string,int>();
            bool bExit = false;
            int iValue = 0;

            while (false == bExit)
            {
                Console.WriteLine("First name?");
                string sFirstName = Console.ReadLine();
                if ("exit" == sFirstName.ToLower())
                {
                    break;
                }

                if (false == dIntString.ContainsKey(sFirstName))
                {
                    dIntString.Add(sFirstName,iValue);
                    iValue++;
                    Console.WriteLine(sFirstName + " was added!");
                }
                else
                {
                    Console.WriteLine(sFirstName + " already exists with value " + dIntString[sFirstName]);
                }
            }

            Console.Clear();
            Menu();
        }

        static void ExerciseSeven()
        {
            ConsoleKey ckInput = ConsoleKey.A;

            while (ConsoleKey.Escape != ckInput)
            {
                PopulateBlizzFans();
                ckInput = Console.ReadKey().Key;
            }
            if (ConsoleKey.Escape == ckInput)
            {
                Console.Clear();
            }




            //for (int i = 0; i < 10; i++)
            //{
            //    BlizzardFan bfNew = new BlizzardFan();

            //    bfNew.sName = "Bob";
            //    bfNew.uiAge = 40;
            //    bfNew.hasTicket = false;

            //    tvBlizzCon2018.AddFan(bfNew);
            //}

            tvBlizzCon2018.TryTicket();
            tvBlizzCon2018.Report();

            Console.ReadKey();
            Console.Clear();
            Menu();
        }

        static void PopulateBlizzFans()
        {
            BlizzardFan bfNew = new BlizzardFan();
            bool bTryAgain = true;

            Console.WriteLine("Enter name:");
            bfNew.sName = Console.ReadLine();

            while (true == bTryAgain)
            {
                Console.WriteLine("Enter age:");
                string sInput = Console.ReadLine();
                if (true == uint.TryParse(sInput, out bfNew.uiAge))
                {
                    bTryAgain = false;
                }
                else
                {
                    Console.WriteLine("That's not a number! Try again!");
                }
            }

            bfNew.hasTicket = false;

            tvBlizzCon2018.AddFan(bfNew);

            Console.WriteLine("{0}, age {1}, has been added to the ticket queue!", bfNew.sName, bfNew.uiAge);

            Console.WriteLine("Press Escape to exit. Any other key to continue making fans.");

        }

        static void Main(string[] args)
        {
            Menu();
            
            Console.ReadKey();
        }

        static void Menu()
        {
            Console.WriteLine("---Menu---");
            Console.WriteLine("Select an option:");

            Console.WriteLine("1. Person Queue");
            Console.WriteLine("2. Encryption");
            Console.WriteLine("3. Encryption 2.0");
            Console.WriteLine("4. Sort, De-Dupe List");
            Console.WriteLine("5. Hashing");
            Console.WriteLine("6. Dictionary");
            Console.WriteLine("7. BlizzCon");

            MenuSelect(Console.ReadLine());
        }

        static void MenuSelect(string _sSelection)
        {
            switch (_sSelection.ToLower())
            {
                case "1":
                case "one":
                    {
                        ExerciseOne();
                        break;
                    }
                case "2":
                case "two":
                    {
                        ExerciseTwo();
                        break;
                    }
                case "3":
                case "three":
                    {
                        ExerciseThree();
                        break;
                    }
                case "4":
                case "four":
                    {
                        ExerciseFour();
                        break;
                    }
                case "5":
                case "five":
                    {
                        ExerciseFive();
                        break;
                    }
                case "6":
                case "six":
                    {
                        ExerciseSix();
                        break;
                    }
                case "7":
                case "seven":
                    {
                        ExerciseSeven();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid selection. Try again.");
                        Menu();
                        break;
                    }

            }
        }

    }
}
