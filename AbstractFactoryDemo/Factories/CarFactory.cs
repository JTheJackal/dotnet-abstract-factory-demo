using AbstractFactoryDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDemo.Factories
{
    public class CarFactory : IAbstractVehicleFactory
    {

        public Vehicle CreateVehicle(string type, string colour, int horsepower)
        {

            Console.WriteLine("A vehicle has been requested from the Car Factory");

            switch (type)
            {

                case "Honda Civic":

                    return new HondaCivic(colour, horsepower);

                case "Ford Ranger":

                    return new FordMustang(colour, horsepower);

                default:

                    return null;
            }
        }
    }
}
