using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetApp.BasicTopics
{
    internal class Manager:EmployeeInherit
    {
     
        private static string _company;




        static Manager()
        {

            _company = "Logic Hub ";

        }

        public static void SetManager(string company)
        {

            _company = company;

        }



        public string Name { get; set; } = "";


        public int Id { get; set; }




       


        public void ShowDetails()
        {

            Console.WriteLine($"Id:{Id}\nName:{Name}\nCompany:{_company}");
        }

        public override void GroupData()
        {
            Console.WriteLine("Manager Groupdata Invoked");

        }

    }



}
