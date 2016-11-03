using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOIntro
{
    interface IEdible
    {
        double Weight { get; set; }
        void GetEaten() { };
    }
}
