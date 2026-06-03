using DotNetApp.Abstraction;
using DotNetApp.Abstraction.Cars;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetApp.Car.Maruti.Cars
{
 internal class Swift : ICar
    {
        public void Drive()
        {
            Console.WriteLine("Swift Is Driving");
        }

        public void Refuel()
        {
            Console.WriteLine("Swift Is Being Refueled");

        }

        public void Service()
        {
            Console.WriteLine("Swift Is Being Serviced");

        }

        public void Start()
        {
            Console.WriteLine("Swift Is Started");

        }

        public void Stop()
        {
            Console.WriteLine("Swift Is Stopped");

        }

        public void Tyres()
        {
            Console.WriteLine("Swift Has 14 Inch 4 Alloy Wheels");

        }

      public void HatchBackCar()
        {
      
            Console.WriteLine("Swift Is A HatchBack Car ");
        }

        void IVehicle.Brake()
        {
            Console.WriteLine("IVehicle Swift Brake");
            
            }

        void ITyres.Brake()
        {
            Console.WriteLine("ITyres Swift Brake");

        }

      
    }
}
