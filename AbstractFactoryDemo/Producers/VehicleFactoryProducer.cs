using AbstractFactoryDemo.Factories;
using AbstractFactoryDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDemo.Producers
{
    public class VehicleFactoryProducer
    {

        public static IAbstractVehicleFactory CreateVehicleFactory(string type)
        {

            Console.WriteLine($"A Vehicle factory has been requested. Returning a factory for the request: {type}");
            switch (type)
            {

                case "Truck":

                    return new TruckFactory();

                case "Car":

                    return new CarFactory();

                default:

                    return null;
            }
        }
    }
}
