using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threads_6
{
    internal class TimezoneThread
    {
        public Timezone Timezone { get; set; }

        public TimezoneThread(Timezone timezone)
        {
            Timezone = timezone;
        }

        public void Print()
        {
            Console.WriteLine($"Hi I am {Thread.CurrentThread.Name} Thread");
        }
    }
}
