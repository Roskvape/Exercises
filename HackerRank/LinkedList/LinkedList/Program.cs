using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> llList = new LinkedList<int>();
            int iPos = 2;


            llList.AddFirst(16);
            llList.AddLast(13);
            llList.AddLast(7);

            foreach (int i in llList)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("");

            LinkedListNode<int> llnCurr = llList.First;

            for (int i =0; i < iPos; i++)
            {
                llnCurr = llnCurr.Next;
            }

            llList.AddBefore(llnCurr, 1);

            foreach (int i in llList)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("");

            Console.ReadKey();
        }
    }
}
