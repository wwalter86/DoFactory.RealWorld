using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoFactory.RealWorld
{
    class Wolf:Carnivore
    {
        public override void Eat(Herbivore h)
        {
            // Eat Bison

            Console.WriteLine(this.GetType().Name +
              " eats " + h.GetType().Name);
        }
    }
}
