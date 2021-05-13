namespace Chapter9_Iterator
{
    public class DinerMenuIterator : IIterator
    {
        private readonly MenuItem[] _items;
        private int position = 0;

        public DinerMenuIterator(MenuItem[] items)
        {
            _items = items;
        }

        public bool HasNext()
        {
            if (position >= _items.Length || _items[position] == null)
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
