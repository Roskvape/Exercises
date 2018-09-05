using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeConversion
{
    class Program
    {

        static string timeConversion(string s)
        {
            string[] sTemp = { "#", "#", ":", "#", "#", ":", "#", "#" };
            string sConverted = "";

            for (int i = 0; i < s.Length - 2; i++)
            {
                sTemp[i] = Convert.ToString(s[i]);
            }

            Console.WriteLine("Orignal");
            Console.WriteLine(s);

            Console.WriteLine("");

            if (s[8] == 'A' && s[0] == '1' && s[1] == '2')
            {
                sTemp[0] = "0";
                sTemp[1] = "0";
            }
            else if (s[8] == 'A' || (s[8] == 'P' && s[0] == '1' && s[1] == '2'))
            {
            }
            else
            {
                int iTemp0 = int.Parse(sTemp[0]);
                int iTemp1 = int.Parse(sTemp[1]);
                iTemp0 += 1;
                iTemp1 += 2;
                sTemp[0] = Convert.ToString(iTemp0);
                sTemp[1] = Convert.ToString(iTemp1);
            }

            foreach (string x in sTemp)
            {
                sConverted += x;
            }

            return sConverted;

        }

        static void Main(string[] args)
        {
            string s1 = "07:05:45PM";
            string s2 = "07:05:45AM";
            string s3 = "12:05:45PM";
            string s4 = "12:05:45AM";

            timeConversion(s1);
            timeConversion(s2);
            timeConversion(s3);
            timeConversion(s4);

            Console.ReadKey();
        }
    }
}
