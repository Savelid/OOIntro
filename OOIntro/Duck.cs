using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOIntro
{
    class Duck : Animal
    {
        public Duck(string color, double weight) : base(color, weight)
        {
        }
        public Duck() : this("White", 1.1)
        {
        }
        public override string MakeSound()
        {
            return "Qwack!";
        }
    }
}
