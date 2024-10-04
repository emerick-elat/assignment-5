using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threads_6
{
    internal sealed class Timezone
    {
        private string Code {  get; set; }
        private string Description { get; set; }
        private int Offset { get; set; }

        public Timezone(string code, string description, int offset)
        {
            Code = code;
            Description = description;
            Offset = offset;
        }

        public override string ToString()
        {
            return $"{Code}: {Description} (GMT{Offset})";
        }
    }
}
