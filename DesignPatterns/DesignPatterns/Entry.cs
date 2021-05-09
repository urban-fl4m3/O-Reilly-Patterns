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

            Console.ReadKey();
        }
    }
}
