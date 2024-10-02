using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threads_5
{
    internal class Printer
    {
        private readonly string Currency;

        public Printer(string currency)
        {
            Currency = currency;
        }

        public void Print(int value)
        {
            Console.WriteLine($"{Currency} {value}");
        }
    }
}
