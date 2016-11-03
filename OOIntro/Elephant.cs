using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOIntro
{
    class Elephant : Animal
    {
        public Elephant(double weight) : base("Gray", weight)
        {
        }
        public Elephant() : this(2500)
        {
        }
        public override string MakeSound()
        {
            return "Tuut!";
        }
    }
}
