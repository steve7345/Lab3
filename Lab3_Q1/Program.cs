using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            CarClass c1 = new CarClass();
            c1.Make = "Ford";
            c1.Model = "Focus";
            c1.CurrentSpeed = 0;
            c1.EngineSize = 1.6;

            CarClass c2 = new CarClass();
            c2.Make = "Opel";
            c2.Model = "Astra";
            c2.CurrentSpeed = 0;
            c2.EngineSize = 1.2;

            Console.WriteLine($"The {c1.Make} {c1.Model}, engine size {c1.EngineSize}L is currently travelling at {c1.CurrentSpeed}Km/h");
            Console.WriteLine($"The {c2.Make} {c2.Model}, engine size {c2.EngineSize}L is currently travelling at {c2.CurrentSpeed}Km/h");

        }
    }
}
