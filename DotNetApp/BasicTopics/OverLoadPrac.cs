using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetApp.BasicTopics
{
    internal class OverLoadPrac
    {



        public void Add(int x, int y) 
        {

            int res = x * y;
            Console.WriteLine($"{x}*{y}={res}\n");
        
        
        }

        public void Add(int x, int y,int z)
        {

            int res = x*y*z;
            Console.WriteLine($"{x}*{y}*{z}={res}\n");


        }


        public void Add(int x, int y, int z ,int a )
        {

            int res = x * y * z*a;
            Console.WriteLine($"{x}*{y}*{z}*{a}={res}\n");


        }

        public void Add(int x, int y, int z, int b ,int d)
        {

            int res = x * y * z*b*d;
            Console.WriteLine($"{x}*{y}*{z}*{b}*{d}={res}\n");


        }


     








    }







}
