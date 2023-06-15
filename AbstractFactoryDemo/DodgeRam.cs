using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDemo
{
    public class DodgeRam : Truck
    {
        public DodgeRam(string colour, int horsepower) : base(colour, horsepower)
        {
        }

        public override void Drive()
        {
            Console.WriteLine($"Driving a Dodge Ram that is {colour} and has {horsepower} BHP");
        }
    }
}
