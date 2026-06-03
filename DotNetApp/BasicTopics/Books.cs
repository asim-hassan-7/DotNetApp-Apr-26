using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetApp.BasicTopics
{
    internal class Books
    {
        public string BookName = "";
        public int BookPrice = 0;
        public string Writer = "";
        public int BookRating = 0;



        public void SetBook(string BookName,int BookPrice,string Writer,int BookRating)
        {
            this.BookName = BookName;   
            this.BookPrice = BookPrice;     
            this.Writer = Writer;
            this.BookRating = BookRating;


        }

        public void Purchased()
        {
            Console.WriteLine($"{this.BookName}\n");
            Console.WriteLine($"Written By: {this.Writer}\n");
            Console.WriteLine($"{this.BookName} Has Been Purchased\n");
            Console.WriteLine($"Price Of {this.BookName} Is Rs:{this.BookPrice}\n");
            Console.WriteLine($"The Number Of Ratings Is {this.BookRating} /10\n");

        }



    }
}
