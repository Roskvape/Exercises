using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkAndToys
{
    class Program
    {
        static int maximumToys(int[] prices, int k)
        {
            int iToysBought = 0;
            int iFundsUsed = 0;

            for (int i = 0; i < prices.Length; i++)
            {
                for (int x = i+1; x < prices.Length; x++)
                {
                    if (prices[i] > prices[x])
                    {
                        prices[i] ^= prices[x];
                        prices[x] ^= prices[i];
                        prices[i] ^= prices[x];
                    }


                }
                if (iFundsUsed + prices[i] < k)
                {
                    iFundsUsed += prices[i];
                    iToysBought++;
                }
                else
                {
                    break;
                }
            }

            return iToysBought;
        }

        static void Main(string[] args)
        {
            int[] prices = { 1, 12, 5, 111, 200, 1000, 10 };
            int k = 50;

            Console.WriteLine(maximumToys(prices,k));

            Console.ReadKey();
        }
    }
}
