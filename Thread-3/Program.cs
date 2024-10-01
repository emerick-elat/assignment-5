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
        }
    }
}
