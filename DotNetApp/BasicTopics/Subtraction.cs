using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetApp.BasicTopics
{
    internal class Subtraction
    {


        public int Res = 0;


        public void Sub(int x, int y)
        {
            Res = x - y;

            Console.WriteLine($"x={x},y={y} res={Res}");
        }
    }
}
