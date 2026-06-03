using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetApp.MyAbstraction
{
    internal abstract class Porche:VehicleAbstract
    {
        public override void Start()
        {
            Console.WriteLine("Porche Is Starting");
        }

        public abstract void Brand();

    }
}
