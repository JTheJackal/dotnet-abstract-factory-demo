// See https://aka.ms/new-console-template for more information
using AbstractFactoryDemo;
using AbstractFactoryDemo.Interfaces;
using AbstractFactoryDemo.Producers;

Console.WriteLine("Starting program!");

IAbstractVehicleFactory vehicleFactory = VehicleFactoryProducer.CreateVehicleFactory("Truck");

if (vehicleFactory != null)
{

    Vehicle newDodgeRam = vehicleFactory.CreateVehicle("Dodge Ram", "Red", 250);

    newDodgeRam.Drive();
}