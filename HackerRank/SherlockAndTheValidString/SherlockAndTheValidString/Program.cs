using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SherlockAndTheValidString
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "ibfdgaeadiaefgbhbdghhhbgdfgeiccbiehhfcggchgghadhdhagfbahhddgghbdehidbibaeaagaeeigffcebfbaieggabcfbiiedcabfihchdfabifahcbhagccbdfifhghcadfiadeeaheeddddiecaicbgigccageicehfdhdgafaddhffadigfhhcaedcedecafeacbdacgfgfeeibgaiffdehigebhhehiaahfidibccdcdagifgaihacihadecgifihbebffebdfbchbgigeccahgihbcbcaggebaaafgfedbfgagfediddghdgbgehhhifhgcedechahidcbchebheihaadbbbiaiccededchdagfhccfdefigfibifabeiaccghcegfbcghaefifbachebaacbhbfgfddeceababbacgffbagidebeadfihaefefegbghgddbbgddeehgfbhafbccidebgehifafgbghafacgfdccgifdcbbbidfifhdaibgigebigaedeaaiadegfefbhacgddhchgcbgcaeaieiegiffchbgbebgbehbbfcebciiagacaiechdigbgbghefcahgbhfibhedaeeiffebdiabcifgccdefabccdghehfibfiifdaicfedagahhdcbhbicdgibgcedieihcichadgchgbdcdagaihebbabhibcihicadgadfcihdheefbhffiageddhgahaidfdhhdbgciiaciegchiiebfbcbhaeagccfhbfhaddagnfieihghfbaggiffbbfbecgaiiidccdceadbbdfgigibgcgchafccdchgifdeieicbaididhfcfdedbhaadedfageigfdehgcdaecaebebebfcieaecfagfdieaefdiedbcadchabhebgehiidfcgahcdhcdhgchhiiheffiifeegcfdgbdeffhgeghdfhbfbifgidcafbfcd";
            Dictionary<char, int> cDic = new Dictionary<char, int>();

            foreach (char x in s)
            {
                if (cDic.ContainsKey(x) == false)
                {
                    cDic.Add(x, 1);
                }
                else
                {
                    cDic[x]++;
                }
            }

            int[] iCounter = new int[cDic.Count()];
            int iInc = 0;
            int iTotal = 0;

            foreach (KeyValuePair<char,int> x in cDic)
            {
                iCounter[iInc] = x.Value;
                iTotal += x.Value;
                iInc++;
            }

            if (iCounter.Min() * iCounter.Count() == iTotal || iCounter.Min() * iCounter.Count() == iTotal - 1 || iCounter.Max() * (iCounter.Count() - 1) == iTotal - 1)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }



            Console.ReadKey();
        }
    }
}
