using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetApp.BasicTopics
{
    public class Employ
    {
        public int Id {  get; set; }
        public string Name {  get; set; }

    }

    public class Stud
    {
        public int Roll { get; set; }
        public int Marks { get; set; }
    }

    public class Mix 
    {
        public static dynamic MulRet()
        {
            Employ E1 = new Employ { Id = 101, Name = "Dayaan"};
            Stud S1 = new Stud {Roll = 77, Marks = 498 };

            //dynamic Method

            var Newobj = new
            {
                id = E1.Id,
                name = E1.Name,
                roll = S1.Roll,
                marks = S1.Marks   
            };

            return Newobj;

            //Another Method
            //EmpStdReturn EsCompact = new EmpStdReturn { emp = E1, std = S1 };
            //return EsCompact;
         

        }



    }
      

    }
