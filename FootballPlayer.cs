using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MertsFootballModel
{
    class FootballPlayer : Person
    {
        public int Number { get; set; }
        public double Height { get; set; }
        public FootballPlayer(string name, int age, int number, double height) : base(name, age)
        {
            Number = number;
            Height = height;

        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Number: {0}", Number);
            Console.WriteLine("Height: {0}m", Height);
        }
    }
}
