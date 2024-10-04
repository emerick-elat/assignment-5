using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threads_6
{
    internal class Timezone
    {
        private string? Code {  get; set; }
        private string? Description { get; set; }
        private int Offset { get; set; }

        public override string ToString()
        {
            return $"{Code}: {Description} (GMT{Offset})";
        }
    }
}
