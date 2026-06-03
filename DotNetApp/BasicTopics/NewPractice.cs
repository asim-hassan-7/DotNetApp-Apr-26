using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetApp.BasicTopics
{
    internal class NewPractice
    {
        public int x = 0;
        public int y = 0;
        public int Res = 0;


        public void Add(int x,int y)
        {
            this.x= x;
            this.y = y;
            Res = this.x + this.y;
            Console.WriteLine($"x={this.x},y={this.y} res={Res}");


        }



    }
}
