using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoFactory.GangOfFour.Abstract.RealWorld
{
    class World
    {
        public void Construct(AnimalBuilder animalBuilder)
            {
                animalBuilder.BuildFood();
                animalBuilder.BuildWeight();
                animalBuilder.BuildLive();
                animalBuilder.BuildAverageLife();
            }        
    }
}
