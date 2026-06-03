using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetApp.BasicTopics
{
    public class DeveloperInherit : EmployeeInherit
    {
        public string _name = string.Empty;

        public DeveloperInherit()
        {
            Console.WriteLine("Developer Default Constructor Called");
        }

        public DeveloperInherit(int id, string name) : base(id)
        {
            _name = name;
            Console.WriteLine($"Developer Parameterized Constructor Called = {_name}");

        }



        public override  void Show()
        {
            //base.Show();
            Console.WriteLine($"Running Child Show Name = {_name}");
        }


        public override void GroupData()
        {
            Console.WriteLine("Developer Groupdata Invoked");
            
        }


    }
}

