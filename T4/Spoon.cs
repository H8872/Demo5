using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4
{
    class Spoon : Tool
    {
        public string Width { get; set; }

        public override string ToString()
        {
            return "  - Type: Spoon" + base.ToString() + " Width: " + Width;
        }
    }
}
