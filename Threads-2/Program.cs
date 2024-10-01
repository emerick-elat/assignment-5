namespace Threads_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] contents = { "January", "February", "March", "April", "May", "June" };
            Thread[] threads = new Thread[contents.Length];

            for (int i = 0; i < contents.Length; i++) {
                CharThread thread = new CharThread(contents[i]);
                threads[i] = new Thread(new ThreadStart(thread.PrintContent));
                threads[i].Start();
            }

            foreach (Thread thread in threads)
            {
                thread.Join();
            }
        }
    }
}
