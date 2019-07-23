using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoFactory.GangOfFour.Abstract.RealWorld
{
    class HerbivoreBuilder:AnimalBuilder
    {
        
        
    public HerbivoreBuilder()
    {
        Animal animal = new Animal("Herbivore");
    }
 
    public override void BuildFood()
    {
        animal["food"] = "Vegetable";
    }

    public override void BuildWeight()
    {
        animal["weight"] = "100";
    }

    public override void BuildLive()
    {
        animal["live"] = "Terrestrial";
    }

    public override void BuildAverageLife()
    {
        animal["AverageLife"] = "2";
    }
    }
}
