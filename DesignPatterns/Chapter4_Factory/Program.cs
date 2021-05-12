using System;

namespace Chapter4_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore nyStore = new NYPizzaStore();
            PizzaStore chicagoStore = new ChicagoPizzaStore();

            Pizza pizza = nyStore.OrderPizza("cheese");
            Console.WriteLine($"Ethan orderer a {pizza.GetName()}\n");

            //pizza = chicagoStore.OrderPizza("cheese");
            //Console.WriteLine($"Joel orderer a {pizza.GetName()}\n");

            Console.ReadKey();
        }
    }
}
