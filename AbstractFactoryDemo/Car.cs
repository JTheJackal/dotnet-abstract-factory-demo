using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDemo
{
    public abstract class Car : Vehicle
    {

        public Car(string colour, int horsepower) : base(colour, horsepower)
        {
            Console.WriteLine("Constructing a Car");
        }
    }
}
