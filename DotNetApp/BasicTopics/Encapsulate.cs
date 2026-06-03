using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;
using System.Text;

namespace DotNetApp.BasicTopics
{
    internal class Encapsulate
    {
        int _empId = 0;
        string _empName = "";
        int _empAge= 0;
        int _empSalary = 0;


        //SETTER
        public void SetId(int id) {
            _empId = id;
            
        }
        //GETTER
        public int GetId()
        {
            Console.WriteLine($"id : {_empId}");
            return _empId;
        }


        //SETTER
        public void SetSalary(int salary)
        {
            _empSalary = salary;

        }
        //GETTER
        public int GetSalary()
        {
            Console.WriteLine($"Salary : {_empSalary}");
            return _empSalary;
        }

        public void SetName(string name)
        {
            if (name.Length<3)
            {
                Console.WriteLine("Name should contain atLeast 3 characters");
            }
            else if (name.Length > 15)
            {
                Console.WriteLine("Name should contain less than 15 characters");
            }
            else
            {
                _empName = name;
            }

        }
        //GETTER
        public string GetName()
        {
            Console.WriteLine($"Name : {_empName}");
            return _empName;
        }

        public void SetAge(int age)
        {
            if (age < 18)
            {
                Console.WriteLine("Age should be greater than 18");
               
                
            }   else if(age > 60)
            {
                Console.WriteLine("Age should be less than 60");
            }
            else
            {
                 _empAge = age;
            }

        }

        //GETTER
        public int GetAge()
        {
            Console.WriteLine($"age: {_empAge}");
            return _empAge;
        }

    }





}



