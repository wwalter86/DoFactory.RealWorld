using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoFactory.RealWorld
{
    class Lion:Carnivore
    {
        public override void Eat(Herbivore h)
        {
            // Eat Wildebeest

            Console.WriteLine(this.GetType().Name +
              " eats " + h.GetType().Name);
        }
    }
}
