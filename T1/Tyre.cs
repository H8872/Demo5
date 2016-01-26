using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*

    Name : string
    Model : string
    Size : string

*/

namespace T1
{
    class Tyre
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public string Size { get; set; }

        public override string ToString()
        {
            return "\n  - Name: " + Name + " Model: " + Model + " Size: " + Size;
        }
    }
}
