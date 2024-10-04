using System.Threading;
using Thread_3;

namespace Threads_3
{
    internal class Program
    {
        public static int InitialNumber { get; set; } = 0;
        public static int TargetValue { get; set; }

        static void Main(string[] args)
        {
            int numberOfThreads = 0, targetNumber = 0;

            Console.WriteLine("Please enter the number of Threads");
            int.TryParse(Console.ReadLine(), out numberOfThreads);
            Console.WriteLine("Please enter the Target Number");
            int.TryParse(Console.ReadLine(), out targetNumber);
            TargetValue = targetNumber;
            Thread[] threads = new Thread[numberOfThreads];
            CancellationTokenSource cts = new CancellationTokenSource();
            for (int i = 0; i < threads.Length; i++)
            {
                IncrementThread iThread = new IncrementThread(i+1, IncrementTargetValue);
                threads[i] = new Thread(new ThreadStart(() => iThread.Run(cts)));
                threads[i].Start();
            }

            foreach (Thread thread in threads)
            {
                thread.Join();
            }
        }

        public static void IncrementTargetValue(int increment, CancellationTokenSource cts)
        {
            if (InitialNumber + increment <= TargetValue)
            {
                InitialNumber += increment;
                Console.WriteLine(InitialNumber);
            }
            else
            {
                cts.Cancel();
                //cts.Dispose();

                Console.WriteLine("Thread terminated gracefully.");
            }
        }
    }
}
