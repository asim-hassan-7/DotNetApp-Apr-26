using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetApp.BasicTopics
{
    internal class Employee
    {
        public int Id;
        public string Name = ("");
        public int Salary;




        public void SetEmployeeData(int i, string n, int s)
        {
         Id=i;
            Name=n; 
            Salary=s;


        }

        public void ShowEmployeeData()

        {


            Console.WriteLine($"Employee:{Id}");
            Console.WriteLine($"Employee:{Name}");
            Console.WriteLine($"Employee:{Salary}");


        }
    }

}
