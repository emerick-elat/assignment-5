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
            while (i < 1000)
            {
                stack.Push(i);
                i += 10;
                Thread.Sleep(2000);
            }
            i = 0;
            foreach (string currency in currencies)
            {
                Printer printer = new Printer(currency);
                printerThreads[i] = new Thread(new ThreadStart(() => { 
                    printer.Print(stack.Pop());
                }));

                printerThreads[i].Start();
            }

            foreach (Thread printer in printerThreads)
            {
                printer.Join();
            }
        }
    }
}
