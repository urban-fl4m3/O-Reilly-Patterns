using System.Collections.Generic;

namespace Chapter9_Iterator
{
    public class PancakeHouseMenu : IIterable
    {
        private readonly List<MenuItem> _items = new List<MenuItem>();

        public PancakeHouseMenu()
        {
            AddItem("K&B's Pancake Breakfast",
                "Pancakes with scrambled eggs, and toast",
                true,
                2.99d);

            AddItem("Regular Pancake Breakfast",
                "Pancakes with fried eggs, sausage",
                false,
                2.99d);

            AddItem("Blueberry Pancakes",
                "Pancakes made with fresh blueberries",
                true,
                3.49d);

            AddItem("Waffles",
                "Waffles, with your choice of blueberries or strawberries",
                true,
                3.59d);
        }

        public void AddItem(string name, string description, bool vegeterian, double price)
        {
            MenuItem item = new MenuItem(name, description, vegeterian, price);
            _items.Add(item);
        }

        public IIterator CreateIterator()
        {
            return new PancakeHouseMenuIterator(_items);
        }
    }
}
