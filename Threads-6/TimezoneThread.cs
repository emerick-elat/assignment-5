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

        public TimezoneThread(ref Timezone timezone)
        {
            Timezone = timezone;
        }
    }
}
