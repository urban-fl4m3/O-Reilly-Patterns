using System;

namespace Chapter8_TemplateMethod
{
    public class Coffee : CaffeineBeverage
    {
        protected override void Brew()
        {
            Console.WriteLine("Dripping Coffee through filter");
        }

        protected override void AddCondiments()
        {
            Console.WriteLine("Adding sugar and milk");
        }

        protected override bool CustomerWantsCondiments()
        {
            var answer = GetUserInput();
            return answer.ToLower().StartsWith("y");
        }

        private string GetUserInput()
        {
            Console.WriteLine("Would you like milk and sugar with your coffee (y/n)?");
            return Console.ReadLine();
        }
    }
}
