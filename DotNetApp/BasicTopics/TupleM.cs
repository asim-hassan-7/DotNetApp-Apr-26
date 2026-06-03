using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetApp.BasicTopics
{
    public class TupleM
    {


        public static (int, int) GetData(int a, int b)
        {
            int sum = a + b;
            int mul = a * b;

            return (sum, mul);




        }


    }

}
