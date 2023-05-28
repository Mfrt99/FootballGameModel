﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MertsFootballModel
{
    class Goalkeeper : FootballPlayer
    {
        public Goalkeeper(string name, int age, int number, double height) : base(name, age, number, height)
        {

        }
        public override void Print()
        {
            Console.WriteLine("Goalkeeper");
            base.Print();
        }
    }
}
