using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4
{
    class Program
    {
        static void Main(string[] args)
        {
            Fork fork = new Fork { Material = "Steel", Grip = "10 cm", Lenght = "13,5 cm", Points = 4 };

            CutleryBox laatikko = new CutleryBox();
            laatikko.Color = "White";
            laatikko.Size = "Medium";
            laatikko.AddFork(fork);
            laatikko.AddFork(fork);

            Console.WriteLine(laatikko.ToString());

            Console.ReadLine();
        }
    }
}
