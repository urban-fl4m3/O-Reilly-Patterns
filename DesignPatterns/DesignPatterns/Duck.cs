using System;

namespace DesignPatterns
{
    public abstract class Duck
    {
        protected IFlyBehaviour _flyBehaviour;
        protected IQuackBehaviour _quackBehaviour;

        public Duck()
        {

        }

        public abstract void Display();

        public void PerformFly()
        {
            _flyBehaviour.Fly();
        }

        public void PerformQuack()
        {
            _quackBehaviour.Quack();
        }

        public void Swim()
        {
            Console.WriteLine("All ducks float, even decoys");
        }
    }
}
