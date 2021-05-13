using System.Collections.Generic;

namespace Chapter9_Iterator
{
    public class CafeMenu : Menu
    {
        private readonly Dictionary<string, MenuItem> _items = new Dictionary<string, MenuItem>();
    
        public CafeMenu() : base("", "")
        {
            AddItem("Veggie Burger and Air Fries",
                "Veggie burger on a whole wheat bun, lettuce, tomato, and fries",
                true,
                3.99d);

            AddItem("Soup of the day",
                "A cup of the soup of the day, with a side salad",
                false,
                3.69d);

            AddItem("Burrito",
                "A large burrito, with whole pinto beans, salsa, guacamole",
                true,
                4.29d);
        }

        public void AddItem(string name, string description, bool vegeterian, double price)
        {
            MenuItem item = new MenuItem(name, description, vegeterian, price);
            _items.Add(item.GetName(), item);
        }

        public IIterator CreateIterator()
        {
            return new CafeMenuIterator(_items);
        }
    }
}
