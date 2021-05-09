using System;

namespace DesignPatterns
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            _flyBehaviour = new FlyNoWay();
            _quackBehaviour = new Quack();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a model duck");
        }
    }
}
