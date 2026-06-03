using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetApp.BasicTopics
{
    public class Calculator
    {

        public int x = 0;
        public int y=0;
        public int Res = 0;



        public void Add(int a, int b)
        {
            x = a;
            y = b;
            Res = a + b;

            Console.WriteLine($"{x}+{y}="+Res);

        }

     


    }
}
