using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MertsFootballModel
{
    class Defenderf : FootballPlayer
    {
        public Defenderf(string name, int age, int number, double height) : base(name, age, number, height)
        {

        }
        public override void Print()
        {
            Console.WriteLine("Defender");
            base.Print();
        }
    }
}
