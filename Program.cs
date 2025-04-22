using System;
namespace interfacce;

public class Program 
{
    public static void Main(string[] args)
    {
        IVehicle myAuto=new Car("Ascona");
        IVehicle myMoto=new Cycle("Gitan");
        myAuto.StartEngine();
        myMoto.StartEngine();
        if (myAuto is Car)
        {
            Car mA=(Car)myAuto;
            Console.Write($"{mA.GetType().Name}: ");
            mA.Horn();
        }
        IVehicle[] Veicoli=new IVehicle[] 
        {
            new Car("Honda Civic"),
            new Car("Opel Zafira"),
            new Cycle("Ciao"),
        };
        Console.WriteLine();
        foreach (IVehicle v in Veicoli)
        {
            Console.Write($"{v.GetType().Name}: ");
            v.StartEngine();
        }
        Console.ReadKey();
    }
}
