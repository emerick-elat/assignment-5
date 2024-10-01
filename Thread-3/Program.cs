using Thread_3;

namespace Threads_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfThreads = 0, targetNumber = 0;

            Console.WriteLine("Please enter the number of Threads");
            int.TryParse(Console.ReadLine(), out numberOfThreads);
            Console.WriteLine("Please enter the Target Number");
            int.TryParse(Console.ReadLine(), out targetNumber);

            Thread[] threads = new Thread[numberOfThreads];

            for (int i = 0; i < threads.Length; i++)
            {
                IncrementThread iThread = new IncrementThread();
                threads[i] = new Thread(new ThreadStart(() => { 
                    iThread.Increment(targetNumber);
                }));
                threads[i].Start();
            }

            foreach (Thread thread in threads)
            {
                thread.Join();
            }
        }
    }
}
