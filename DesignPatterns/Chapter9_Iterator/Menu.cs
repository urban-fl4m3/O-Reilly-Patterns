using System;
using System.Collections.Generic;

namespace Chapter9_Iterator
{
    public class Menu : MenuComponent
    {
        private IEnumerator<MenuComponent> _iterator = null;

        private readonly List<MenuComponent> _menuComponents = new List<MenuComponent>();
        private readonly string _name;
        private readonly string _description;

        public Menu(string name, string description)
        {
            _name = name;
            _description = description;
        }

        public override void Add(MenuComponent component)
        {
            _menuComponents.Add(component);
        }

        public override void Remove(MenuComponent component)
        {
            _menuComponents.Remove(component);
        }

        public override MenuComponent GetChild(int i)
        {
            return _menuComponents[i];
        }

        public override string GetName()
        {
            return _name;
        }

        public override string GetDescription()
        {
            return _description;
        }

        public override void Print()
        {
            Console.Write($"\n{GetName()}");
            Console.WriteLine($", {GetDescription()}");
            Console.WriteLine("---------------------");

            var iterator = _menuComponents.GetEnumerator();
            while (iterator.MoveNext())
            {
                MenuComponent component = iterator.Current;
                component.Print();
            }
        }

        public override IEnumerator<MenuComponent> CreateIterator()
        {
            if (_iterator == null)
            {
                _iterator = new CompositeIterator(_menuComponents.GetEnumerator());
            }

            return _iterator;
        }
    }
}
