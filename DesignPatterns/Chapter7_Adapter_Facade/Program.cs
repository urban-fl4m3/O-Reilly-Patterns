using System;

namespace Chapter7_Adapter_Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            IDuck duck = new MallardDuck();
            ITurkey turkey = new WildTurkey();
            IDuck turkeyAdapter = new TurkeyAdapter(turkey);

            Console.WriteLine("The turkey says...");
            turkey.Gobble();
            turkey.Fly();

            Console.WriteLine("\nThe duck says...");
            TestDuck(duck);

            Console.WriteLine("\nThe turkey adapter says...");
            TestDuck(turkeyAdapter);


            Console.ReadKey();
        }

        private static void TestDuck(IDuck duck)
        {
            duck.Quack();
            duck.Fly();
        }
    }
}
