using System;
using System.Collections.Generic;

namespace Chapter4_Factory
{
    public abstract class Pizza
    {
        protected string _name;
        protected IDough _dough;
        protected ISauce _sauce;
        protected IVeggies[] _veggies;
        protected ICheese _cheese;
        protected IPepperoni _pepperoni;
        protected IClams _clam;

        protected readonly List<string> _toppings = new List<string>();

        public abstract void Prepare();

        public virtual void Bake()
        {
            Console.WriteLine($"Bake for 25 minutes at 350");
        }

        public virtual void Cut()
        {
            Console.WriteLine($"Cutting the pizza into diagonal slices");
        }

        public virtual void Box()
        {
            Console.WriteLine($"Place pizza in official PizzaStore box");
        }

        public virtual string GetName()
        {
            return _name;
        }

        public void SetName(string name)
        {
            _name = name;
        }
    }
}
