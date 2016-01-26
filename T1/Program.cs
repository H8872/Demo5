using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace T1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tyres
            Tyre nokia = new Tyre { Name = "Nokia", Model = "Hakkapeliitta", Size = "205R16" };
            Tyre micb = new Tyre { Name = "Mic", Model = "Pilot", Size = "160R17" };
            Tyre mics = new Tyre { Name = "Mic", Model = "Pilot", Size = "140R16" };


            //Vehicles
            Vehicle porsche = new Vehicle();
            porsche.Name = "Porsche";
            porsche.Model = "911";
            porsche.AddTyre(nokia);
            porsche.AddTyre(nokia);
            porsche.AddTyre(nokia);
            porsche.AddTyre(nokia);

            Vehicle ducati = new Vehicle();
            ducati.Name = "Ducati";
            ducati.Model = "Diavel";
            ducati.AddTyre(micb);
            ducati.AddTyre(mics);

            //Print stuff
            Console.WriteLine(porsche.ToString());
            Console.WriteLine(ducati.ToString());

            Console.ReadLine();
        }
    }
}
