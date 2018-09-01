using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk5_Data
{
    class TicketVendor
    {
        private Queue<BlizzardFan> ticketQueue = new Queue<BlizzardFan>();
        private List<BlizzardFan> completedList = new List<BlizzardFan>();
        int iTicketsLeft = 5;

        public void AddFan(BlizzardFan _bfFan)
        {
            ticketQueue.Enqueue(_bfFan);
        }

        public void TryTicket()
        {
            BlizzardFan bfCurrent;
            while (ticketQueue.Any())
            {
                bfCurrent = ticketQueue.Dequeue();
                if (iTicketsLeft > 0)
                {
                    bfCurrent.hasTicket = true;
                    iTicketsLeft--;
                }
                completedList.Add(bfCurrent);
            }
        }

        public void Report()
        {
            foreach (BlizzardFan x in completedList)
            {
                Console.WriteLine("{0}, age {1}, has a ticket? {2}", x.sName, x.uiAge, x.hasTicket);
            }
        }
    }
}
