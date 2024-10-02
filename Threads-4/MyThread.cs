using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threads_4
{
    internal class MyThread
    {
    }

    internal abstract class Motorcycle
    {
        public void StartEngine() { }
        public virtual int Drive(int id) {  return 0; }
        public abstract double GetTopSpeed();
    }

    internal class MyMotorcycle : Motorcycle
    {
        public new void StartEngine()
        {
            int x = 1;
        }

        public override int Drive(int id)
        {
            return 1 + base.Drive(id);
        }

        public override double GetTopSpeed()
        {
            throw new NotImplementedException();
        }
    }
}
