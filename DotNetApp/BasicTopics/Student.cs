using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetApp.BasicTopics
{
    internal class Student
    {
        public int id;
        public string Name = "";
        public string Adress = "";




        public void SetStudentData(int i, string n, string a)
        {
    
        id = i;
        Name= n;
        Adress = a;

        }


        public void ShowStudentData() {

            Console.WriteLine($"Roll No:{id}");
            Console.WriteLine($"Name:{Name}");
            Console.WriteLine($"Adress:{Adress}");



        }                                       
    }
}
