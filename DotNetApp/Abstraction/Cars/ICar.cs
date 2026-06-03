using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetApp.Abstraction.Cars
{
   internal  interface ICar:IVehicle,ITyres
    {
        void SuvCar()
        {
            Console.WriteLine("This Is An SUV Car" );
        }
        void HatchBackCar()
        {
            Console.WriteLine("This Is A HatchBack Car");
        }

     
    }
}
