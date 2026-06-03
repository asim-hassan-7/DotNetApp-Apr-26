using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace DotNetApp.BasicTopics
{
    public class ShopKeeper:ShopName
    {
        private string _name = string.Empty;
        private string _position = string.Empty;
        private int _salary = 0;

             public ShopKeeper()

        {   
            Console.WriteLine("Default Constructor Of Shop Keeper\n");
        }

        public ShopKeeper(string name,string position ,int salary)
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
            Console.WriteLine($"Salary:{_salary}\n\n");
        }


    }
}
