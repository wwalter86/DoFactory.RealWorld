using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoFactory.RealWorld
{
    class AmericaFactory : IContinentFactory
    {
        public Herbivore CreateHerbivore()
        {
            return new Bison();
        }
        public Carnivore CreateCarnivore()
        {
            return new Wolf();
        }
    }
}
