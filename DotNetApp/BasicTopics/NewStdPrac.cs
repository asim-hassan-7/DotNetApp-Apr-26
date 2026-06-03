using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetApp.BasicTopics;

internal class NewStdPrac
{
    private string _name = "";
    private int _age = 0;
    private int _division = 0;



    public string Name
    {


        set
        {
            if (value.Length >= 3 && value.Length <= 12)
                _name = value;
            else
                Console.WriteLine("Name must be between 3 and 12 characters.");

        }
        

        get
        {
            return _name;

        }

    }

    public int Age
    {
        set
        {
            if (value >= 18 && value <=60)
                _age = value;
            else
                Console.WriteLine("Age Must Lie Between 18 To 60 Chsaracters");
        }

        get
        {
            return _age;

        }

    }


    public int Division
    {




        set
        {
            _division = value;

        }

        get
        {
            return _division;

        }



     


}


    public string Address { set; get; } = "";
    public int RoleNo { get; set; }

}

    





