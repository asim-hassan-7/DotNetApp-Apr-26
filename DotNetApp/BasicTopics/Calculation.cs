using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetApp.BasicTopics
{
    internal class Calculation
    {
        public static bool Compare(int a, int b)
        {
            return a == b;
        }
        public static bool Compare(string a, string b)
        {
            return a == b;
        }

        public static bool GenericCompare<T>(T a, T b)
        {
            return a.Equals(b);
        }
    }
}
