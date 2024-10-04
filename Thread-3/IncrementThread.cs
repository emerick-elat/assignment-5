using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thread_3
{
    internal class IncrementThread
    {
        public int Increment { get; set; }
        private IncrementFunc Callback;

        public IncrementThread(int increment, IncrementFunc callback)
        {
            Increment = increment;
            Callback = callback;
        }

        public void Run(CancellationTokenSource cts)
        {
            while (!cts.Token.IsCancellationRequested)
            {
                if (Callback is not null)
                {
                    Callback(Increment, cts);
                }
            }
        }
    }

    public delegate void IncrementFunc(int increment, CancellationTokenSource cts);
}
