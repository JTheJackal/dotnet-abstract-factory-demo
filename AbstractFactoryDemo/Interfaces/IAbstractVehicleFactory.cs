﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDemo.Interfaces
{
    public interface IAbstractVehicleFactory
    {
        Vehicle CreateVehicle(string type, string colour, int horsepower);
    }
}
