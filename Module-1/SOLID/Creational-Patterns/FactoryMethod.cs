using System;

interface IVehicle
{
    void Start();
}

class Car : IVehicle
{
    public void Start()
    {
        Console.WriteLine("Car started");
    }
}

class Bike : IVehicle
{
    public void Start()
    {
        Console.WriteLine("Bike started");
    }
}

class VehicleFactory
{
    public static IVehicle GetVehicle(string type)
    {
        if (type == "Car")
        {
            return new Car();
        }

        return new Bike();
    }
}

class Program
{
    static void Main()
    {
        IVehicle vehicle = VehicleFactory.GetVehicle("Car");

        vehicle.Start();
    }
}