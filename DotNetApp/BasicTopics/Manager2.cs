using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetApp.BasicTopics
{
    internal class Manager2
    {
        private static String _school;

        static Manager2()
        {

            _school = "DPS";
        }

        public static void SetManager2(string school)
        {
            _school = school;
        }


       public int Id {  get; set; }
        public string Name { get; set; }

        public void Showmanager2()
        {


            Console.WriteLine($"Name:{Name}\n\nId:{Id}\n\nSchool:{_school}");

        }
 
    }
}
