namespace Threads_2
{
    internal class Program
    {
        private static Mutex mutex = new Mutex();
        static void Main(string[] args)
        {   
            string[] contents = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October" };
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

        public static void PrintContent(string Content)
        {
            if (mutex.WaitOne(1000))
            {
                Console.ForegroundColor = GetRandomConsoleColor();
                foreach (char c in Content)
                {
                    Console.Write(c);
                    //Thread.Sleep(100);
                }

                Console.ResetColor();
                Console.WriteLine();
                mutex.ReleaseMutex();
            }
        }

        static ConsoleColor GetRandomConsoleColor()
        {
            Random random = new Random();
            ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));
            return colors[random.Next(colors.Length)];
        }

        ~Program()
        {
            mutex.Dispose();
        }
    }
}
