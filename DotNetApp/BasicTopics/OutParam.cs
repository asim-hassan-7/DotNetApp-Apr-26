using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetApp.BasicTopics
{
    public class OutParam
    {
        public static void MulRet (int a,int b, out int c, out int d)
        {

            c = a + b;
            d = a - b;
        }


    }
}
