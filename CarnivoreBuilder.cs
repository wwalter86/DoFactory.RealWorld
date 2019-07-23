using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoFactory.GangOfFour.Abstract.RealWorld
{
    class CarnivoreBuilder:AnimalBuilder
    {
        
    public CarnivoreBuilder()
    {
        Animal animal = new Animal("Carnivore");
    }
 
    public override void BuildFood()
    {
        animal["food"] = "Meat";
    }

    public override void BuildWeight()
    {
        animal["weight"] = "500";
    }

    public override void BuildLive()
    {
        animal["live"] = "Terrestrial";
    }

    public override void BuildAverageLife()
    {
        animal["AverageLife"] = "5";
    }
    }
}
