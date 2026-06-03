using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace DotNetApp.BasicTopics
{
    internal class EncapPrac
    {



        private int _id = 0;
        private string _name = "";
        private int _age = 0;



        //SET

       public void SetId(int id)
        {
            _id = id;
            Console.WriteLine($"Id:{_id}\n");
        }

        //GET
            public int GetId()
        {
            Console.WriteLine($"Id:{_id}\n");
            return _id;
        }




        //SET

        public void SetName(string name)
        {
            if (name.Length >2 && name.Length <12 )

            {
                _name = name;
                Console.WriteLine($"SetName:{name}\n");
            }
            else
                Console.WriteLine("Name Should At least 2 To 12 ");
        }

        //GET
        public string GetName()
        {
            Console.WriteLine($"GetName:{_name}\n");
            return _name;
        }



        //SET


        public void SetAge(int age)
        {
            if (age > 18 && age < 60) 
            {
                _age = age;
                Console.WriteLine($"Age:{age}\n");

            }

            else

                Console.WriteLine("Minimum Age Required 18+\n" +
                    "Maximum Age Reuired Below 60");
        }
       

        //GET


        public int GetAge()
        {
            Console.WriteLine($"Age:{_age}\n");
            return _age;
            
           
        }





    }
}
