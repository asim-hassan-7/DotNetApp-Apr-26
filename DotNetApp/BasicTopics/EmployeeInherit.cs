using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace DotNetApp.BasicTopics
{
    public class EmployeeInherit


    {
        public int _id = 1;
        public EmployeeInherit()
        {
            Console.WriteLine("Employee Default Constructor Called");
        }

        public EmployeeInherit(int id)
        {

          _id= id;
           Console.WriteLine($"Employee Parameterized Constructor Called = {_id}");

        }

        public void SetData(int id)
        { 
        _id = id;
        
        }

        public virtual void Show()
        {
           
            Console.WriteLine($"Running Parent Show Id = {_id}");
        }

        public virtual void GroupData()
        {
            Console.WriteLine("Employee Groupdata Invoked");

        }

        
    }


    




}
