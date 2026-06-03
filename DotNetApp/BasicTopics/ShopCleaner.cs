using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetApp.BasicTopics
{
    public class ShopCleaner:ShopName
    {
        private string _name = string.Empty;
        private string _position = string.Empty;
        private int _salary = 0;

        public ShopCleaner()
        {
            Console.WriteLine("Default Constructor Of Shop Cleaner\n");
        }
        public ShopCleaner(string name,string position,int salary)
        {
             _name = name;
            _position = position;
            _salary = salary;
        }

        public override void Show()
        {
            Console.WriteLine($"Shop Name:{_shopname}");
            Console.WriteLine($"Name:{_name}");
            Console.WriteLine($"Position:{_position}");
            Console.WriteLine($"Salary:{_salary}");
        }

    }
    }

