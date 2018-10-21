using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketLuckyNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int luckyTicketsCount = 0;
            int unluckyTicketsCount = 0;

            for (int i = 0; i < 1000000; i++)
            {
                if ((i / 100000 + i % 100000 / 10000 + i % 100000 % 10000 / 1000) == (i % 100000 % 10000 % 1000 / 100 + i % 100000 % 10000 % 1000 % 100 / 10 + i % 10))
                {
                    Console.WriteLine(i);
                    luckyTicketsCount++;
                }
                else
                {
                    unluckyTicketsCount++;
                }
            }

            Console.WriteLine("Total lucky ticket numbers are: " + luckyTicketsCount);
            Console.WriteLine("Total not lucky ticket numbers are: " + unluckyTicketsCount);
            Console.WriteLine($"Total tickets existing are: {luckyTicketsCount + unluckyTicketsCount}");
        }
    }
}
