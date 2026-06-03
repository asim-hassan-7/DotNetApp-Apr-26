using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetApp.BasicTopics;

internal class DefaultM
{

    public static string Sum(string name, string email, params int[] salary)
    {
        int res = 0;

        foreach (int item in salary)
        {
            res += item;
        }

        return $"Name:{name}\n\nEmail:{email}\n\nSalary:{res}\n\n";

    }

}