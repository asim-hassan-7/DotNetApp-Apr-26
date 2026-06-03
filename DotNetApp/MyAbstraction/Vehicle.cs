using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetApp.MyAbstraction
{
    public abstract class Vehicle
    {
        public abstract int Model { set; get; }

        public abstract void Start();

    }


    public class Bmw : Vehicle
    {
        public override int Model { get; set; }
        public Bmw(int _model)
        {
            this.Model = _model;
        }
        public override void Start()
        {
            Console.WriteLine($"Bmw Model {Model} Starting....");
        }

    }


    public class Maruti : Vehicle
    {
        public override int Model { get; set; }
        public Maruti(int _model)
        {
            this.Model = _model;
        }
        public override void Start()
        {
            Console.WriteLine($"Maruti Model {Model} Starting....");
        }

    }
}

