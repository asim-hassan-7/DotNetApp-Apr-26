using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetApp.Abstraction.Cars
{
    internal interface ITruck:IVehicle,ITyres
    {

        void HeavyTruck();
        void LightTruck();

    }
}
