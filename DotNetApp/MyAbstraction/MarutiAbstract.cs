using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetApp.MyAbstraction
{
    public class MarutiAbstract:VehicleAbstract
    {
        public override void Start()
        {
            Console.WriteLine($"Maruti Model Starting");
        }


    }
}
