using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk5_Data
{
    class PersonQueue
    {
        private Queue<Person> qpPeople;

        public PersonQueue()
        {
            qpPeople = new Queue<Person>();
        }

        public void AddPerson(Person _pNew)
        {
            qpPeople.Enqueue(_pNew);
        }

        //public void Pull()
        //{
        //    if (qpPeople.Count() != 0)
        //    {
        //        Person pCurrent;
        //        pCurrent = PullPerson();
        //        Console.WriteLine("{0}, {1}", pCurrent.sName, pCurrent.uiAge);
        //    }
        //    else
        //    {
        //        Console.WriteLine("Queue is empty.");
        //    }
        //}

        public Person PullPerson()
        {
                return qpPeople.Dequeue();
        }

    }
}
