using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetApp.BasicTopics
{
    internal class Student2
    {
        int _id = 0;
        string _name = "";
        int _age = 0;


        // default constructor

        public Student2()
        {
            _id = 101;
            _name = "Asim";
            _age = 24;


        }


        //parameterized constructor

        public Student2( int id,  string name,int age) { 
        
            _id=id; 
            _name=name;
            _age=age;  
        }


        // show function
        public void ShowStudent()
        {

            Console.WriteLine($"{_id}");
            Console.WriteLine($"{_name}");
            Console.WriteLine($"{_age}");




        }



    }
}
