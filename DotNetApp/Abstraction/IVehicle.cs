using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetApp.Abstraction
{
    internal interface IVehicle
    {

        void Start();
        void Stop();
        void Drive();
        void Refuel();
        void Service();
        void Brake();
    

        //void Horn()
        //{
        //    Console.WriteLine("Vehicle Horn");  Default Implementation
        //}


    }
}
