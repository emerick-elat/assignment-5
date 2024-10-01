using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thread_3
{
    internal class IncrementThread
    {
        public int Value { get; set; }

        public IncrementThread()
        {
            Value = 0;
        }

        public void Increment(int targetNumber, int index)
        {
            if (Value <= targetNumber)
            {
                Value+=index;
            }
        }
    }
}
