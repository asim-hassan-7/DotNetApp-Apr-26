using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetApp.BasicTopics
{
    public class ReturnValue
    {

        public int Num1 {  get; set; }
        public int Num2 {  get; set; }
        public int Num3 {  get; set; }
        public int Num4 {  get; set; }
      


    }
    public class Cal()
    {
        public static ReturnValue Mul(int x, int y)
        {

            ReturnValue rv = new ReturnValue();
            rv.Num1 = x;
            rv.Num2 = y;
            rv.Num3 = x + y;
            rv.Num4 = x * y;
            return rv;
        }


    }
}
