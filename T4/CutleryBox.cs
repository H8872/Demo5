using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4
{
    class CutleryBox
    {
        public string Color { get; set; }
        public string Size { get; set; }
        public List<Tool> Tools { get; set; }

        public CutleryBox()
        {
            Tools = new List<Tool>();
        }

        public void AddFork(Fork fork)
        {
            Tools.Add(fork);
        }
        public override string ToString()
        {
            string sCutleryBox = "\n Box Color: " + Color + " Size: " + Size + " Tools:";
            foreach(Tool fork in Tools)
            {
                sCutleryBox += fork.ToString();
            }
            return sCutleryBox;
        }
    }
}
