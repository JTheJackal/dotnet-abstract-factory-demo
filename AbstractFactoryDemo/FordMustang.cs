using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDemo
{
    public class FordMustang : Car
    {
        public FordMustang(string colour, int horsepower) : base(colour, horsepower)
        {
        }

        public override void Drive()
        {
            Console.WriteLine($"Driving a Ford Mustang that is {colour} and has {horsepower} BHP");
        }
    }
}
