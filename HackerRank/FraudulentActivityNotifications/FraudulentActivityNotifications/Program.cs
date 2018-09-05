using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FraudulentActivityNotifications
{
    class Program
    {
        public static int iMed = 0;
        public static int iMed1 = 0;
        public static int iMed2 = 0;
        public static decimal dMedianValue = 0m;

        //static decimal GetMedian(List<int> _input)
        //{
        //    decimal dMedian = 0m;

        //    if (_input.Count() % 2 == 0)
        //    {
        //        int iHalf1 = _input[(_input.Count() / 2) - 1];
        //        int iHalf2 = _input[_input.Count() - (_input.Count() / 2)];
        //        dMedian = (iHalf1 + iHalf2) / 2m;
        //    }
        //    else
        //    {
        //        dMedian = _input[_input.Count() / 2];
        //    }

        //    return dMedian;
        //}

        //static int activityNotifications(int[] expenditure, int d)
        //{
        //    Queue<int> qExpiry = new Queue<int>();
        //    List<int> lTrail = new List<int>();
        //    int iAlertCount = 0;

        //    for (int i = 0; i < d; i++)
        //    {
        //        lTrail.Add(expenditure[i]);
        //        qExpiry.Enqueue(expenditure[i]);
        //    }
        //    lTrail.Sort();

        //    for (int i = d; i < expenditure.Length; i++)
        //    {
        //        if (expenditure[i] >= GetMedian(lTrail) * 2)
        //        {
        //            //Console.WriteLine("Alert!");
        //            iAlertCount++;
        //        }

        //        lTrail.Add(expenditure[i]);
        //        qExpiry.Enqueue(expenditure[i]);
        //        lTrail.Remove(qExpiry.Dequeue());
        //        lTrail.Sort();
        //    }

        //    return iAlertCount;
        //}

        // ------

        //static decimal GetMedian(LinkedList<int> _llTrail, int _iTrailLength)
        //{
        //    LinkedListNode<int> nodeMedian = new LinkedListNode<int>(0);
        //    LinkedListNode<int> nodeMedian1 = new LinkedListNode<int>(0);
        //    LinkedListNode<int> nodeMedian2 = new LinkedListNode<int>(0);
        //    decimal dMedian = 0m;

        //    // Find original median(s)
        //    if (_iTrailLength % 2 == 0)
        //    {
        //        // Even
        //        nodeMedian1 = _llTrail.First;
        //        nodeMedian2 = _llTrail.First.Next;

        //        for (int i = 0; i < (_iTrailLength / 2) - 1; i++)
        //        {
        //            nodeMedian1 = nodeMedian1.Next;
        //            nodeMedian2 = nodeMedian2.Next;
        //        }
        //        //Console.WriteLine("Med1 is:" + nodeMedian1.Value);
        //        //Console.WriteLine("Med2 is:" + nodeMedian2.Value);
        //        dMedian = (nodeMedian1.Value + nodeMedian2.Value) / 2m;
        //    }
        //    else
        //    {
        //        // Odd
        //        nodeMedian = _llTrail.First;
        //        for (int i = 0; i < (_iTrailLength - 1) / 2; i++)
        //        {
        //            nodeMedian = nodeMedian.Next;
        //        }
        //        //Console.WriteLine("Med is:" + nodeMedian.Value);
        //        dMedian = nodeMedian.Value;
        //    }

        //    return dMedian;
        //}

        //static int activityNotifications(int[] expenditure, int d)
        //{
        //    Queue<int> qExpiry = new Queue<int>();
        //    LinkedList<int> llTrail = new LinkedList<int>();
        //    int iAlertCount = 0;

        //    // Setup of initial trail and queue.
        //    llTrail.AddFirst(expenditure[0]);
        //    qExpiry.Enqueue(expenditure[0]);
        //    for (int i = 1; i < d; i++)
        //    {


        //        bool bInserted = false;
        //        foreach (int x in llTrail)
        //        {
        //            if (x > expenditure[i])
        //            {
        //                llTrail.AddBefore(llTrail.Find(x), expenditure[i]);
        //                bInserted = true;
        //                break;
        //            }
        //        }
        //        if (bInserted == false)
        //        {
        //            llTrail.AddLast(expenditure[i]);
        //        }

        //        qExpiry.Enqueue(expenditure[i]);
        //    }

        //    for (int i = d; i < expenditure.Length; i++)
        //    {

        //        if (expenditure[i] >= GetMedian(llTrail, d) * 2)
        //        {
        //            //Console.WriteLine("Alert!");
        //            //Console.WriteLine(expenditure[i] + " >= " + GetMedian(llTrail, d) + " times 2.");
        //            iAlertCount++;
        //        }

        //        LinkedListNode<int> llnCurrent = llTrail.First;

        //        // Find where to insert next value
        //        for (int x = 0; x < d; x++)
        //        {
        //            if (llnCurrent.Value > expenditure[i])
        //            {
        //                llTrail.AddBefore(llnCurrent, expenditure[i]);
        //                break;
        //            }
        //            else
        //            {
        //                if (x == d-1)
        //                {
        //                    llTrail.AddAfter(llnCurrent, expenditure[i]);
        //                }
        //            }

        //            llnCurrent = llnCurrent.Next;

        //        }

        //        // Enqueue next value.
        //        qExpiry.Enqueue(expenditure[i]);

        //        // Remove oldest trail value.
        //        int iWhat = qExpiry.Dequeue();

        //        llTrail.Remove(iWhat);

        //    }

        //    return iAlertCount;
        //}


        //static decimal GetNewMedian(Queue<int> _q, int _in, int _out)
        //{
        //    decimal dMedian = 0m;

        //    if (_q.Count%2==0)
        //    {
        //        if (_in <= iMed1 && _out >= iMed2)
        //        {
        //            // For Even, going down
        //            for (int i = iMed1; i > 0; i--)
        //            {
        //                if (_q.Contains(i))
        //                {
        //                    int iTemp = iMed1;
        //                    iMed1 = i;
        //                    Console.WriteLine("Median1 is now " + iMed1);
        //                    iMed2 = iTemp;
        //                    Console.WriteLine("Median2 is now " + iMed2);
        //                    break;
        //                }
        //            }
        //        }
        //        else if (_in >= iMed2 && _out <= iMed1)
        //        {
        //            // For Even, going up
        //            for (int i = iMed2; i <= 200; i++)
        //            {
        //                if (_q.Contains(i))
        //                {
        //                    int iTemp = iMed2;
        //                    iMed2 = i;
        //                    Console.WriteLine("Median2 is now " + iMed2);
        //                    iMed1 = iTemp;
        //                    Console.WriteLine("Median1 is now " + iMed1);
        //                    break;
        //                }
        //            }
        //        }
        //        else if (_in <= iMed2 && _in >= iMed1 && _out <= iMed1)
        //        {
        //            iMed1 = _in;
        //            Console.WriteLine("Median1 is now " + iMed1);
        //            Console.WriteLine("Median2 is unchanged.");
        //        }
        //        else if (_in <= iMed2 && _in >= iMed1 && _out >= iMed2)
        //        {
        //            iMed2 = _in;
        //            Console.WriteLine("Median2 is now " + iMed2);
        //            Console.WriteLine("Median1 is unchanged.");
        //        }
        //        else
        //        {
        //            // Do nothing
        //        }

        //        dMedian = (iMed1 + iMed2) / 2m;
        //    }
        //    else // If Odd
        //    {
        //        if (_in <= iMed && _out >= iMed)
        //        {
        //            // For Odd, going down
        //            for (int i = iMed; i > 0; i--)
        //            {
        //                if (_q.Contains(i))
        //                {
        //                    iMed = i;
        //                    Console.WriteLine("Median is now " + iMed);
        //                    break;
        //                }
        //            }
        //        }
        //        else if (_in >= iMed && _out <= iMed)
        //        {
        //            // For Odd, going up
        //            for (int i = iMed; i <= 200; i++)
        //            {
        //                if (_q.Contains(i))
        //                {
        //                    iMed = i;
        //                    Console.WriteLine("Median is now " + iMed);
        //                    break;
        //                }
        //            }
        //        }
        //        else
        //        {
        //            // Do nothing
        //        }

        //        dMedian = iMed;
        //    }

        //    return dMedian;
        //}

        //static void GetInitialMedian(LinkedList<int> _llTrail, int _iTrailLength)
        //{
        //    LinkedListNode<int> nodeMedian = new LinkedListNode<int>(0);
        //    LinkedListNode<int> nodeMedian1 = new LinkedListNode<int>(0);
        //    LinkedListNode<int> nodeMedian2 = new LinkedListNode<int>(0);

        //    // Find original median(s)
        //    if (_iTrailLength % 2 == 0)
        //    {
        //        // Even
        //        nodeMedian1 = _llTrail.First;
        //        nodeMedian2 = _llTrail.First.Next;

        //        for (int i = 0; i < (_iTrailLength / 2) - 1; i++)
        //        {
        //            nodeMedian1 = nodeMedian1.Next;
        //            nodeMedian2 = nodeMedian2.Next;
        //        }

        //        iMed1 = nodeMedian1.Value;
        //        iMed2 = nodeMedian2.Value;
        //    }
        //    else
        //    {
        //        // Odd
        //        nodeMedian = _llTrail.First;
        //        for (int i = 0; i < (_iTrailLength - 1) / 2; i++)
        //        {
        //            nodeMedian = nodeMedian.Next;
        //        }

        //        iMed = nodeMedian.Value;
        //    }
        //}

        //static int activityNotifications(int[] expenditure, int d)
        //{
        //    Queue<int> qExpiry = new Queue<int>();
        //    LinkedList<int> llTrail = new LinkedList<int>();
        //    int iAlertCount = 0;

        //    // Setup of initial trail and queue.
        //    llTrail.AddFirst(expenditure[0]);
        //    qExpiry.Enqueue(expenditure[0]);
        //    for (int i = 1; i < d; i++)
        //    {


        //        bool bInserted = false;
        //        foreach (int x in llTrail)
        //        {
        //            if (x > expenditure[i])
        //            {
        //                llTrail.AddBefore(llTrail.Find(x), expenditure[i]);
        //                bInserted = true;
        //                break;
        //            }
        //        }
        //        if (bInserted == false)
        //        {
        //            llTrail.AddLast(expenditure[i]);
        //        }

        //        qExpiry.Enqueue(expenditure[i]);
        //    }

        //    // Set initial medians(s) int.
        //    GetInitialMedian(llTrail, d);

        //    // Iterate through expenditures and send alerts
        //    for (int i = d; i < expenditure.Length; i++)
        //    {
        //        qExpiry.Enqueue(expenditure[i]);
        //        int iOut = qExpiry.Dequeue();

        //        if (expenditure[i] >= GetNewMedian(qExpiry, expenditure[i], iOut) * 2)
        //        {
        //            //Console.WriteLine("Alert!");
        //            iAlertCount++;
        //        }


        //    }

        //    return iAlertCount;
        //}

        static void SortTrail(int[] _trail)
        {
            for (int i = 0; i < _trail.Length; i++)
            {
                for (int x = 0; x < _trail.Length-1; x++)
                {
                    if (_trail[x] > _trail[x + 1])
                    {
                        _trail[x] ^= _trail[x + 1];
                        _trail[x + 1] ^= _trail[x];
                        _trail[x] ^= _trail[x + 1];
                    } 
                }
            }

        }

        static int[] InsertTrail(int[] _trail, int _in, int _out)
        {
            int[] newTrail = new int[_trail.Length];
            bool bDropped = false;
            bool bAdded = false;
            int iInc = 0;

            for (int i = 0;  i < _trail.Length; i++)
            {
                if (_trail[i] == _out && bDropped == false)
                {
                    // Skip
                    bDropped = true;
                }
                else if (_trail[i] < _in && i + 1 == _trail.Length && bAdded == false)
                {
                    newTrail[iInc] = _trail[i];
                    newTrail[iInc + 1] = _in;
                    bAdded = true;
                    iInc += 2;
                }
                else if (_trail[i] < _in && _trail[i+1] >= _in && bAdded == false)
                {
                    newTrail[iInc] = _trail[i];
                    newTrail[iInc + 1] = _in;
                    bAdded = true;
                    iInc+=2;
                }
                else
                {
                    newTrail[iInc] = _trail[i];
                    iInc++;
                }
            }

            SetMedian(newTrail);

            return newTrail;
        }

        static void SetMedian(int[] _trail)
        {
            if (_trail.Length % 2 == 0)
            {
                iMed1 = _trail.Length / 2;
                iMed2 = (_trail.Length / 2) + 1;
                dMedianValue = (_trail[iMed1] + _trail[iMed2]) / 2m;
                //Console.WriteLine("new median value: " + dMedianValue);
            }
            else
            {
                iMed = Convert.ToInt16(Math.Round(_trail.Length / 2m, MidpointRounding.AwayFromZero))-1;
                dMedianValue = _trail[iMed];
                //Console.WriteLine("new median value: " + dMedianValue);
            }
        }

        static int activityNotifications(int[] expenditure, int d)
        {
            Queue<int> qExpiry = new Queue<int>();
            int[] iTrail = new int[d];
            int iAlertCount = 0;

            // Setup of initial trail and queue.

            for (int i = 0; i < d; i++)
            {
                iTrail[i] = expenditure[i];
                qExpiry.Enqueue(expenditure[i]);
                //Console.WriteLine(expenditure[i]);
            }

            SortTrail(iTrail);

            SetMedian(iTrail);
            
            for (int i = d; i < expenditure.Length; i++)
            {
                if (expenditure[i] >= dMedianValue * 2)
                {
                    //Console.WriteLine("Alert!");
                    iAlertCount++;
                }

                iTrail = InsertTrail(iTrail, expenditure[i], qExpiry.Dequeue());
                qExpiry.Enqueue(expenditure[i]);

            }

            //Console.WriteLine("\nAfter insert sort:");
            //foreach (int i in iTrail)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine("\nAlerts:");
            return iAlertCount;
        }

        static void Main(string[] args)
        {
            int[] aData1 = { 2, 3, 4, 2, 3, 6, 8, 4, 5 };
            int aTrailLength1 = 5;
            int[] aData2 = { 1, 2, 3, 4, 4 };
            int aTrailLength2 = 4;
            int[] aData3 = { 10, 20, 30, 40, 50 };
            int aTrailLength3 = 3;

            Console.WriteLine(activityNotifications(aData1, aTrailLength1));
            Console.WriteLine("");
            Console.WriteLine(activityNotifications(aData2, aTrailLength2));
            Console.WriteLine("");
            Console.WriteLine(activityNotifications(aData3, aTrailLength3));


            Console.ReadKey();
        }
    }
}
