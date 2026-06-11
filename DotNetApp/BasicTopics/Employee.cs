using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetApp.BasicTopics
{
    internal class Employee:Student
    {
     
        private int Salary;




        public void SetEmployeeData(int id, string name, int salary)
        {
            this.id = id;
            this.Name = name;
            Salary= salary;
           


        }

        public void ShowEmployeeData()

        {


            Console.WriteLine($"Employee:{id}");
            Console.WriteLine($"Employee:{Name}");
            Console.WriteLine($"Employee:{Salary}\n\n\n\n");


        }
    }

}
