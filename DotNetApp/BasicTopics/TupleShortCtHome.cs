using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetApp.BasicTopics
{
    public class TupleShortCtHome
    {
        public  string Name { get; set; }
        public  int Id { get; set; }
        public  int Salary { get; set; }
        public  string Email { get; set; }


        public (string name, int id, int salary, string email) GetData()
        {
            return (Name, Id, Salary, Email);

        }
    }
}
