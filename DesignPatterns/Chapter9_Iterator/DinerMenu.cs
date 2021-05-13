using System;

namespace Chapter9_Iterator
{
    public class DinerMenu : Menu
    {
        private const int _maxCount = 4;
        private int _numberOfItems = 0;
        private readonly MenuItem[] _items;

        public DinerMenu() : base("Diner menu", "Diner")
        {
            _items = new MenuItem[_maxCount];

            AddItem("Vegeterian BLT",
                "(Fakin') Bacon with lettuce & tomato on whole whheat",
                true,
                2.99d);

            AddItem("BLT",
                "Bacon with lettuce & tomato on whole wheat",
                false,
                2.99d);

            AddItem("Soup of the day",
                "Soup of the day, with a side of potato salad",
                false,
                3.29d);

            AddItem("Hotdog",
                "A hot dog with saurkraut, relish, onionsm topped with cheese",
                false,
                3.05d);
        }

        public void AddItem(string name, string description, bool vegeterian, double price)
        {
            MenuItem item = new MenuItem(name, description, vegeterian, price);
            if (_numberOfItems >= _maxCount)
            {
                Console.WriteLine("Sorry, menu is full! Can't add item to menu!");
            }
            else
            {
                _items[_numberOfItems] = item;
                _numberOfItems++;
            }
        }

        public IIterator CreateIterator()
        {
            return new DinerMenuIterator(_items);
        }
    }
}
