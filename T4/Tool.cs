using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4
{
    class Tool
    {
        public string Material { get; set; }
        public string Lenght { get; set; }
        public string Grip { get; set; }

        public override string ToString()
        {
            return " Material: " + Material + " Lenght: " + Lenght + " Grip: " + Grip;
        }
    }
}
