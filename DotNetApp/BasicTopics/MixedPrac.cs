using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetApp.BasicTopics
{
    public class MixedPrac
    {
        //Private Fields
        private string _name;
        private int _age;
        private double _gpa;


        //Encapsulated
        public String Name
        {

            set
            {
                if (value.Length >= 2 && value.Length <= 30)
                    _name = value;

                else
                    Console.WriteLine("Name must be between 2 and 30 characters");
            }


            get
            {
                return _name;
            }





        }

        public int Age
        {

            set
            {
                if (value >= 18 && value <= 60)
                    _age = value;

                else
                    Console.WriteLine("Age Must Be Between 18-60");
            }


            get
            {
                return _age;
            }





        }


        public double Gpa
        {

            set
            {
                if (value >= 0 && value <= 4.0)
                    _gpa = value;

                else
                    Console.WriteLine(" Gpa  Must Be Between 0 - 4.0.");
            }


            get
            {
                return _gpa;
            }

        }

        //Constructors

        //Default Constructor
        public MixedPrac()
        {
            _name = "Default";
            _age = 18;
            _gpa = 2.2;

        }

        //Parameterized Constructor
        public MixedPrac(int age, double gpa)
        {
            _age = age;
            _gpa = gpa;

        }


        //Overload 

        public void ShowInfo()
        {
            Console.WriteLine($"Age:{_age}\nName:{_name}\nGPA:{_gpa}");

        }

        public void ShowInfo(bool detailed)
        {
            if (detailed)
                Console.WriteLine($"Name:{Name}\nAge:{Age}\nGPA:{Gpa}");

            else
                ShowInfo();
        }





    }
}
