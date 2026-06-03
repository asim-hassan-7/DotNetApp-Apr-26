using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace DotNetApp.BasicTopics
{
    internal class Developer2
    {
        private int _Id = 0;
        private string _Name = "";
        private string _Role = "";



        public int Id
        {
            set
            {

                _Id = value;

            }

            get
            {

                return _Id;

            }

        }

        public string Name
        {
            set
            {
                if (value.Length > 2 && value.Length < 12)
                    _Name = value;

                else

                    Console.WriteLine("Invalid Name Characters,Set Name To Above 0 And Below 15");
            }
            get

            {
                return _Name;

            }
        }


        public string Role
        {
            set

            {

                _Role = value;

            }


            get
            {
                return _Role;
            }
        }

    }


    public class Tester()
    {

        public int Id { set; get; }
        public string Name { get; set; }
        public string Role { get; set; }

    }
}
