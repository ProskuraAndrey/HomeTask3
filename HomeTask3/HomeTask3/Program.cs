using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask3
{
    class Program
    {
        static void Main(string[] args)
        {
            WorkWithStrings workWithStrings = new WorkWithStrings();
            workWithStrings.LongestSentence();

            Console.WriteLine("========================================");

            workWithStrings.WorkWithStringFormat();

            Console.ReadLine();
        }
    }
}
