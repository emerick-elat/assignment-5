namespace Threads_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            string [] currencies = { "EUR", "USD", "YUAN", "GBP", "YEN", "CAD", "XAF", "RUB", "RUP", "PES" };
            Thread[] printerThreads = new Thread[currencies.Length];
            
            int i = 10;
            Console.WriteLine("Content of the Queue:");
            while (i < 130)
            {
                Console.Write($"{i}, ");
                stack.Push(i);
                i += 10;
                Thread.Sleep(1000);
            }
            Console.WriteLine();
            i = 0;
            Console.WriteLine("10 last items");
            foreach (string currency in currencies)
            {
                Printer printer = new Printer(currency);
                printerThreads[i] = new Thread(new ThreadStart(() => { 
                    printer.Print(stack.Pop());
                }));

                printerThreads[i].Start();
                i++;
            }

            foreach (Thread p in printerThreads)
            {
                p.Join();
            }
        }
    }
}
