using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace DotNetApp.BasicTopics
{
    internal class Developer
    {
        private int _id = 0;
        private string _name = "";
        private string _address = "";
        private string _email = "";
        private string _phoneNo = "";
        private string _profile = "";

         
        // default constructors
        public Developer()
        {
        
            _id = 0;
            _name = null;
            _address = null;
            _email = null;
            _phoneNo = "";
            _profile = null;
       
        }


        // parameterized constructor
        public Developer(int id, string name, string address, string email, string phoneNO,string profile )
        {

            _id= id;
            _name = name;
            _address = address;
            _email = email;
            _phoneNo = phoneNO;
            _profile= profile;

        }


        // Copy constructor
        public Developer(Developer d)
        {

            _name = d._name;
            _address = d._address;
            _email = d._email;



        }


        //functions overloading

        public void SetData(int id, string name, string address, string email, string phoneNo, string profile)
        {

            _id = id;
            _name = name;
            _address = address;
            _email = email;
            _phoneNo = phoneNo;
            _profile = profile;

        }

        public void SetData(int id, string name, string address, string email,string profile)
        {

            _id = id;
            _name =name;
            _address  = address;
            _email =email;
            _profile  =profile;
           



        }


        public void SetData(string name,string address,string email)
        {
            _name= name;
            _address= address;
            _email = email;

        }


        public void SetData(string profile,string phoneNo)
        {
            _profile= profile;
            _phoneNo = phoneNo;


        }






        public void ShowData()
        {

            Console.WriteLine($"{_id}\n{_name}\n{_address}\n{_email}\n{_phoneNo}\n{_profile}\n");

        }



    }
}
