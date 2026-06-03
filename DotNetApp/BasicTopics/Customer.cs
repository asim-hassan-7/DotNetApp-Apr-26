using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetApp.BasicTopics
{
    internal class Customer
    {


        string productName = "";
        int productQuantity = 0;


        public Customer()
        {

            this.productName = "Lays";
            this.productQuantity = 10;
           
        
        
        }

        public Customer(string pn,int pq) 
        {
         this.productName=pn;
         this.productQuantity=pq;
            Console.WriteLine($"Customer Asim Purchased:{productName}\nThe Number Of Items He Purchased:{productQuantity}\n");


        
        }


        public void ChangeProductNumQuan(string _pn, int _pq)
        {
            this.productName = _pn;
            this.productQuantity = _pq;
            Console.WriteLine($"Customer Dayaan Changed The Product:{this.productName}\nThe Number Items He Purchased {this.productQuantity}\n");


        }

        public void ShowProducts()
        {

            Console.WriteLine($"Customer Dayaan Purchased: {productName}\n The Number Of Items He Purchased: {productQuantity}\n");


        }



    }
}
