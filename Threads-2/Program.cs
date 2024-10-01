namespace Threads_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] contents = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October" };
            Thread[] threads = new Thread[contents.Length];

            for (int i = 0; i < contents.Length; i++) {
                CharThread thread = new CharThread(contents[i]);
                threads[i] = new Thread(new ThreadStart(() => {
                    thread.PrintContent(GetRandomConsoleColor());
                }));
                threads[i].Start();
            }

            foreach (Thread thread in threads)
            {
                thread.Join();
            }
        }

        static ConsoleColor GetRandomConsoleColor()
        {
            Random random = new Random();
            ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));
            return colors[random.Next(colors.Length)];
        }
    }
}
