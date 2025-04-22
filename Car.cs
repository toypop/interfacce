using System;

namespace interfacce
{
    public class Car : IVehicle
    {
        public string Model{set{}}
        // public string Model;
        public Car(string model)
        {
            this.Model=model;
        }

        public void StartEngine()
        {
            Console.WriteLine("Brummmm");
        }

        public void Horn()
        {
            Console.WriteLine("Hornnn");
        }
    }
}