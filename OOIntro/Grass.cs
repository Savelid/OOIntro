using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOIntro
{
    class Grass : IEdible
    {
        public double Weight { get; set; }
        public Grass(double weight)
        {
            Weight = weight;
        }
        public void GetEaten()
        {
            Weight = 0;
        }
    }
}
