using System;

namespace DesignPatterns
{
    class Entry
    {
        private static void Main()
        {
            var duck = new MallardDuck();
            duck.PerformQuack();
            duck.PerformFly();

            var modelDuck = new ModelDuck();
            modelDuck.PerformFly();
            modelDuck.SetFlyBehaviour(new FlyRocketPowered());
            modelDuck.PerformFly();

            Console.ReadKey();
        }
    }
}
