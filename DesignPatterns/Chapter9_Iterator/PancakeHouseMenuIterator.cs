using System.Collections.Generic;

namespace Chapter9_Iterator
{
    public class PancakeHouseMenuIterator : IIterator
    {
        private readonly List<MenuItem> _items;
        private int position = 0;

        public PancakeHouseMenuIterator(List<MenuItem> items)
        {
            _items = items;
        }

        public bool HasNext()
        {
            if (position >= _items.Count|| _items[position] == null)
            {
                return false;
            }

            return true;
        }

        public object Next()
        {
            MenuItem item = _items[position];
            position++;
            return item;
        }
    }
}
