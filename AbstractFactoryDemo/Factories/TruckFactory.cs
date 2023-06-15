using AbstractFactoryDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDemo.Factories
{
    public class TruckFactory : IAbstractVehicleFactory
    {

        public Vehicle CreateVehicle(string type, string colour, int horsepower)
        {

            Console.WriteLine("A vehicle has been requested from the Truck Factory");

            switch (type)
            {

                case "Dodge Ram":

                    return new DodgeRam(colour, horsepower);

                case "Ford Ranger":

                    return new FordRanger(colour, horsepower);

                default:

                    return null;
            }
        }
    }
}
