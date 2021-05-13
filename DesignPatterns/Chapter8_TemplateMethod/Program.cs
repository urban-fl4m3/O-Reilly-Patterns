using System;

namespace Chapter8_TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            CaffeineBeverage tea = new Tea();
            tea.PrepareRecipe();

            CaffeineBeverage coffee = new Coffee();
            coffee.PrepareRecipe();

            Console.ReadKey();
        }
    }
}
