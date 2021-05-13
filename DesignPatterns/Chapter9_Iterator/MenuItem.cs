using System;
using System.Collections.Generic;

namespace Chapter9_Iterator
{
    public class MenuItem : MenuComponent
    {
        private readonly string _name;
        private readonly string _description;
        private readonly bool _vegeterian;
        private readonly double _price;

        public MenuItem(string name, string description, bool vegeterian, double price)
        {
            _name = name;
            _description = description;
            _vegeterian = vegeterian;
            _price = price;
        }

        public override string GetName()
        {
            return _name;
        }

        public override string GetDescription()
        {
            return _description;
        }

        public override double GetPrice()
        {
            return _price;
        }

        public override bool IsVegeterian()
        {
            return _vegeterian;
        }

        public override void Print()
        {
            Console.Write($"  {GetName()}");
            if (IsVegeterian())
            {
                Console.Write("{v}");
            }
            Console.WriteLine($", {GetPrice()}");
            Console.WriteLine($"    -- {GetDescription()}");
        }

        public override IEnumerator<MenuComponent> CreateIterator()
        {
            return new NullIterator();
        }
    }
}
