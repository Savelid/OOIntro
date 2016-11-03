using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOIntro
{
    abstract class Animal : IEdible
    {
        public static int InstanceCount { get; set; }
        public string Color { get; private set; }
        public double Weight { get; set; }
        protected int Age { get; set; }
        public Animal(string color, double weight)
        {
            Color = color;
            Weight = weight;
            InstanceCount++;
        }
        public virtual void Eat(IEdible food)
        {
            Weight += food.Weight;
            food.GetEaten();
        }
        public void GetEaten()
        {
            Weight = 0;
        }
        public abstract string MakeSound();
    }
}
