namespace Threads_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfThread = 10;
            Thread[] threads = new Thread[numberOfThread]; 
            for (int i = 0; i < threads.Length; i++)
            {
                threads[i] = new Thread(new ThreadStart(PrintInformations));
                threads[i].Start();
            }

            foreach (Thread thread in threads)
            {
                thread.Join();
            }
        }

        static void PrintInformations()
        {
            Console.WriteLine($"Thread ID: {Thread.CurrentThread.ManagedThreadId}  Last Invoke Date: {DateTime.Now.ToString("yyyy-mm-dd:G")}" );
        }
    }
}
