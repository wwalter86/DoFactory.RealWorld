using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoFactory.RealWorld
{
    class Program
    {
        static void Main()
        {
            // Create and run the African animal world

            IContinentFactory africa = new AfricaFactory();
            AnimalWorld world = new AnimalWorld(africa);
            world.RunFoodChain();

            // Create and run the American animal world

            IContinentFactory america = new AmericaFactory();
            world = new AnimalWorld(america);
            world.RunFoodChain();

            // Wait for user input

            AnimalBuilder builder;

            // Create shop with vehicle builders

            World world1 = new World();

            // Construct and display vehicles

            builder = new CarnivoreBuilder();
            world1.Construct(builder);
            builder.Animal.Show();

            builder = new HerbivoreBuilder();
            world1.Construct(builder);
            builder.Animal.Show();

            Console.ReadKey();
        }
    }
}
