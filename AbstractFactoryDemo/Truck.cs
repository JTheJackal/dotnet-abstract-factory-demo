using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDemo
{
    public abstract class Truck : Vehicle
    {

        public Truck(string colour, int horsepower) : base(colour, horsepower)
        {
            Console.WriteLine("Constructing a Truck");
        }
    }
}
