using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoFactory.RealWorld
{
    class AfricaFactory:IContinentFactory
    {
        public Herbivore CreateHerbivore()
            {
                return new Wildebeest();
            }
            public Carnivore CreateCarnivore()
            {
                return new Lion();
            }        
    }
}
