using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace DotNetApp.BasicTopics
{
    public class Studnt
    {
        public static int totalStudents = 0;
        private int[] marks;


        public string Name {  get; set; }
        public int Roll {  get; set; }
           
        //Default Constructor
        public Studnt()
        {
            Name = "unknown";
            Roll = ++totalStudents;
            marks = new int[3];  //3 Subjects
        }

        //Parameterized Constructor
        public Studnt(string name) 
        {
        Roll = ++totalStudents;
        Name = name;
        marks = new int[3];

        }

        //OverLoading
        public void SetMarks(int m1,int m2 , int m3)
        {
            marks[0] = m1;
            marks[1] = m1;
            marks[2] = m2;

        }

        public void Show()
        {

            Console.WriteLine($"Roll:{Roll}\nName:{Name}");
            Console.WriteLine($"Marks:{marks[0]},{marks[1]},{marks[2]}");        
        
        }


        public static void ShowTotalStudents()
        {
            Console.WriteLine($"Total Studnets:{totalStudents}");
       
        }

    }
}
