using DotNetApp.Abstraction;
using DotNetApp.Abstraction.Cars;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetApp.Car.Hyundai.Cars
{
    internal class Creta : ICar
    {
        public void Drive()
        {
            Console.WriteLine("Creta Is Driving");
        }

        public void Refuel()
        {
            Console.WriteLine("Creta Is Being Refueled");

        }

        public void Service()
        {
            Console.WriteLine("Creta Is Being Serviced");

        }

        public void Start()
        {
            Console.WriteLine("Creta Is Started");

        }

        public void Stop()
        {
            Console.WriteLine("Creta Is Stopped");

        }

        public void Tyres()
        {
            Console.WriteLine("Creta Has 14 Inch 4 Alloy Wheels");

        }

        public void SuvCar()
        {

            Console.WriteLine("Creta Is An Suv Car ");
        }

        void IVehicle.Brake()
        {
            Console.WriteLine("IVehicle Creta Brake");

        }

        void ITyres.Brake()
        {
            Console.WriteLine("ITyres Creta Brake");

        }

    }
}
