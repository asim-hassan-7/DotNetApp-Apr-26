using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetApp.BasicTopics
{
    internal class GenricM<T>
    {
        //via Object

        //public static bool Compare(int a, int b)
        //{
        //    return a == b;
        //}
        //public static bool Compare(string a, string b)
        //{
        //    return a == b;
        //}

        //via Genric

        //public static bool GenericCompare<T>(T a, T b)
        //{
        //    return a.Equals(b);
        //}


        //via Genric Class
        public static bool Compare(int a, int b)
        {
            return a == b;
        }
        public static bool Compare(string a, string b)
        {
            return a == b;
        }

        public static bool GenericCompare(T a, T b)
        {

            //Equals Object Function
            return a.Equals(b);
        }




    }
}
