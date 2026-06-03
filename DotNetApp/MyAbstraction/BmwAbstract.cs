using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace DotNetApp.MyAbstraction
{
    public class BmwAbstract:VehicleAbstract
    {
        public override void Start()
        {
            Console.WriteLine($"Bmw Model Starting");
        }
    

    }
}
