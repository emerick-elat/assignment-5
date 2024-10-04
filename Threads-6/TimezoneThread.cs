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

        public void PrintTime(Timezone userTimezone)
        {

            TimeZoneInfo threadTimeZone = TimeZoneInfo.FindSystemTimeZoneById(Timezone.Description);
            TimeZoneInfo userTimeZone = TimeZoneInfo.FindSystemTimeZoneById(userTimezone.Description);

            DateTime sourceTime = DateTime.Now;

            DateTime destinationTime = TimeZoneInfo.ConvertTime(sourceTime, threadTimeZone, userTimeZone);

            // Display the result
            Console.WriteLine($"Thread Time ({threadTimeZone.DisplayName}): {sourceTime}");
            Console.WriteLine($"User Time ({userTimeZone.DisplayName}): {destinationTime}");
        }
    }
}
