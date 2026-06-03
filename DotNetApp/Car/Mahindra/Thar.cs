using DotNetApp.Abstraction;
using DotNetApp.Abstraction.Cars;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetApp.Car.Mahindra.Cars
{
    public class Thar : ICar
    {
        public void Drive()
        {
            Console.WriteLine("Thar Is Driving");

        }

        public void Refuel()
        {
            Console.WriteLine("Thar Is Being Refueled");

        }

        public void Service()
        {
            Console.WriteLine("Thar Is Being Serviced");

        }

        public void Start()
        {
            Console.WriteLine("Thar Is Started");
        }

        public void Stop()
        {
            Console.WriteLine("Thar Is Stopped");

        }

        public void Tyres()
        {
            Console.WriteLine("Thar Has 18 Inch 4 Alloy Wheels");
        }

        public void SuvCar()
        {

            Console.WriteLine("Thar Is An Suv Car ");
        }

        void IVehicle.Brake()
        {
            Console.WriteLine("IVehicle Thar Brake");

        }

        void ITyres.Brake()
        {
            Console.WriteLine("ITyres Thar Brake");

        }

    }
}
