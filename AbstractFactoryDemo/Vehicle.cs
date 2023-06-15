using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDemo
{
    public abstract class Vehicle
    {

        protected string? colour;
        protected bool canTow;
        protected int horsepower;

        public Vehicle(string? colour, int horsepower)
        {
            this.colour = colour;
            this.horsepower = horsepower;
        }

        public abstract void Drive();
    }
}
