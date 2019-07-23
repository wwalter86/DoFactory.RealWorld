using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoFactory.RealWorld
{
    class AnimalWorld
    {

        private Herbivore _herbivore;
        private Carnivore _carnivore;

        // Constructor

        public AnimalWorld(IContinentFactory factory)
        {
            _carnivore = factory.CreateCarnivore();
            _herbivore = factory.CreateHerbivore();
        }

        public void RunFoodChain()
        {
            _carnivore.Eat(_herbivore);
        }
    }
}
