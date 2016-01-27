using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4
{
    class Knife : Tool
    {
        public string Sharpness { get; set; }

        public override string ToString()
        {
            return "  - Type: Knife" + base.ToString() + " Sharpness: " + Sharpness;
        }
    }
}
