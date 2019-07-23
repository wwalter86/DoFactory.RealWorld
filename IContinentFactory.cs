using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoFactory.RealWorld
{
    interface IContinentFactory
    {       
             Herbivore CreateHerbivore();
             Carnivore CreateCarnivore();      
    }
}
