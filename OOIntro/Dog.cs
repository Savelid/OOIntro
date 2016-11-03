using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOIntro
{
    class Dog : Animal
    {
        public Dog(string color, double weight) : base(color, weight)
        {
        }
        public Dog() : this("Brown", 15)
        {
        }
        public override void Eat(IEdible food)
        {
            food.Weight *= 0.8;
            base.Eat(food);
        }
        public override string MakeSound()
        {
            return "Voff!";
        }
    }
}
