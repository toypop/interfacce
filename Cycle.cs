using System;
using System.Dynamic;
namespace interfacce
{
    public class Cycle : IVehicle
    {
        public string Model{get;set;}
        public Cycle(string model)
        {
            this.Model=model;
        }

        public void StartEngine()
        {
            Console.WriteLine("Wrummm");
        }
    }
}