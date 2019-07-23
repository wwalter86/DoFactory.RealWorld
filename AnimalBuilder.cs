using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoFactory.GangOfFour.Abstract.RealWorld
{
     abstract class AnimalBuilder
    {
         protected Animal animal;

            // Gets vehicle instance

            public Animal animal
            {
                get { return animal; }
            }

            // Abstract build methods

            public abstract void BuildFood();
            public abstract void BuildWeight();
            public abstract void BuildLive();
            public abstract void BuildAverageLife();
        
    }
    }

