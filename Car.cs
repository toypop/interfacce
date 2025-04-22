using System;

namespace interfacce
{
    public class Car : IVehicle
    {
        public string Model{ get;set;}
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