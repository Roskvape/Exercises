using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Match");

            string sUserSelect = Console.ReadLine();

            switch (sUserSelect)
            {
                case "one":
                case "1":
                    { //stuff
                        string sFilePath = "C:\\Users\\cmoyer\\Desktop\\Regex Tests\\";
                        Console.WriteLine("You chose Match.");
                        Console.WriteLine("Enter a regex expression:");
                        string pattern = string.Format(@"{0}", Console.ReadLine());
                        string input = "xyz_001.txt";
                        foreach (Match match in Regex.Matches(input, pattern))
                            Console.WriteLine(match.Value);
                        Console.WriteLine("Replace these occurrences with:");
                        string sReplace = Console.ReadLine();

                        string sNewInput = Regex.Replace(input, pattern, sReplace, RegexOptions.None);
                        Console.WriteLine(sNewInput);

                        System.IO.Directory.CreateDirectory(sFilePath + "\\Renamed");
                        System.IO.File.Move(sFilePath + input, sFilePath + "Renamed\\" + sNewInput);

                        //Regex rRegex = new Regex(@"[\w]");
                        //Match rMatch = rRegex.Match("abc ac acb_aob a2b a42c");
                        //if (rMatch.Success)
                        //{
                        //    Console.WriteLine(rMatch.Value);
                        //}

                        //while (rMatch.NextMatch().Success == true)
                        //{
                        //    rMatch = rMatch.NextMatch();
                        //        Console.WriteLine(rMatch.Value);
                        //}
                        Console.ReadLine();
                        break;
                    }
                default:
                {
                    Console.WriteLine("Input invalid. Try again.");
                    Console.ReadLine();
                    Console.Clear();
                    Menu();
                    break;
                }
            }
        }
    }
}
