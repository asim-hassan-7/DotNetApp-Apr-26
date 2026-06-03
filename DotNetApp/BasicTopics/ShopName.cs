using System;
using System.Collections.Generic;
using System.Text;
namespace DotNetApp.BasicTopics;

public class ShopName
{
    protected static string _shopname = "The Basket Hub";

 

    public virtual void Show()
    {
        Console.WriteLine($"Shop Name:{_shopname}");
    }


}
