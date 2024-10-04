using System.Security.Cryptography.X509Certificates;

namespace Threads_6
{
    internal class Program
    {
        public static DateTime CurrentTime = DateTime.Now;

        static void Main(string[] args)
        {
            //System Initialization
            int choice = 0;
            Timezone userTimeZone;
            Timezone[] timezones = new Timezone []
            {
                new Timezone("GMT", "Greenwich Mean Time", 0),
                new Timezone("EST", "Eastern Standard Time", -5),
                new Timezone("CET", "Central European Time", +1),
                new Timezone("JST", "Japan Standard Time", +9),
                new Timezone("AEST", "Australian Eastern Standard Time", 10),
                new Timezone("PST", "Pacific Standard Time", -8)
            };
            Thread[] threads = new Thread[timezones.Length];
            int index = 1;
            foreach (Timezone tz in timezones)
            {
                Console.WriteLine($"{index++}. {tz.ToString()}");
            }
            Console.WriteLine("Enter the number associated with your time zome");
            int.TryParse(Console.ReadLine(), out choice);
            userTimeZone = timezones[choice - 1];
            Console.WriteLine($"Your timezone: {userTimeZone.ToString()}");

            // Threads Initialization
            for (int i = 0; i < threads.Length; i++)
            {
                TimezoneThread timezoneThread = new TimezoneThread(timezones[i]);
                threads[i] = new Thread(new ThreadStart(() => {
                    timezoneThread.PrintTime(userTimeZone);
                }));
                threads[i].Name = timezones[i].ToString();
                threads[i].Start();
            }

            foreach (Thread t in threads)
            {
                t.Join();
            }
        }
    }
}
