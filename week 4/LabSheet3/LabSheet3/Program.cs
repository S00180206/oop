using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSheet3
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new Car();
            c1.make = "Ford";
            c1.Model = "Focus";
            c1.CurrentSpeed = 0;
            c1.EngineSize = 1.6;

            Car c2 = new Car();
            c2.make = "Opel";
            c2.Model = "Astra";
            c2.CurrentSpeed = 0;
            c2.EngineSize = 1.2;

            Console.WriteLine($"the {c1.make}{c1.Model}, engine size {c1.EngineSize}1 is currently traveling at {c1.CurrentSpeed}km/h");
            Console.WriteLine($"the {c2.make}{c2.Model}, engine size {c1.EngineSize}1 is currently traveling at {c2.CurrentSpeed}km/h");

        }
    }
}
