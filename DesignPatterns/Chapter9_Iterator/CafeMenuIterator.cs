using System.Collections.Generic;
using System.Linq;

namespace Chapter9_Iterator
{
    public class CafeMenuIterator : IIterator
    {
        private readonly List<MenuItem> _items;
        private int position = 0;

        public CafeMenuIterator(Dictionary<string, MenuItem> items)
        {
            _items = items.Values.ToList();
        }

        public bool HasNext()
        {
            if (position >= _items.Count || _items[position] == null)
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
