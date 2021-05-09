using System;

namespace DesignPatterns
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            _quackBehaviour = new Quack();
            _flyBehaviour = new FlyWithWings();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a real Mallard duck");
        }
    }
}
