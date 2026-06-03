using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetApp.BasicTopics;

internal class Employee2
{

    int id = 0;
    string name = "";
    int salary = 0;
    string role = "";




    public Employee2(int _id, string _name, int _salary, string _role)
    {
        id = _id;
        name = _name;
        salary = _salary;
        role = _role;

    }

    public void Show()
    {
        Console.WriteLine($"Id:{id}\n\nName:{name}\n\nSalary:{salary}\n\nRole:{role}\n");
    }

    public Employee2 (Employee2 emp)
    {

        id = emp.id;
        name = emp.name;
        salary = emp.salary;
        role= emp.role;

    }

    public Employee2(bool b)
    {

        Console.WriteLine("This Is Diffrence\n");


    }

    public void Change(int id, string name, int salary, string role)
    {
        this.id = id;
        this .name = name;
        this.salary = salary;
        this.role = role;
    }

}
