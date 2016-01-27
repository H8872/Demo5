using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4
{
    class Fork : Tool
    {
        public int Points { get; set; }

        public override string ToString()
        {
            return "\n  - Type: Fork " + base.ToString() + "  Points: " + Points;
        }
    }
}
