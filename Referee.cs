using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MertsFootballModel
{
    class Referee : Person
    {
        public Referee(string name, int age) : base(name, age)
        {
        }
        public override void Print()
        {
            Console.WriteLine("Referre");
            base.Print();
        }
    }
}
