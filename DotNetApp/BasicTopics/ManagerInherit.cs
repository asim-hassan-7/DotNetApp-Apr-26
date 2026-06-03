using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetApp.BasicTopics
{
    public class ManagerInherit : EmployeeInherit
    {
        public string _position = "";
        public ManagerInherit()
        {
            Console.WriteLine("Manager Default Constructor Called");
        }

        public ManagerInherit(string position)
        {

           _position = position;
            Console.WriteLine($"Manager Parameterized Constructor Called = {_position}");

        }

        public void SetData(string position)
        {
            _position = position;


        }

        public override  void Show()
        {

            Console.WriteLine($"Running Manager Show Id = {_position}");
        }


        public override void GroupData()
        {
            Console.WriteLine("Manager Groupdata Invoked");

        }

    }

}
