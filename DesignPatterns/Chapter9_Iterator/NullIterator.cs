using System.Collections;
using System.Collections.Generic;

namespace Chapter9_Iterator
{
    public class NullIterator : IEnumerator<MenuComponent>
    {
        public MenuComponent Current => null;

        object IEnumerator.Current => null;

        public void Dispose()
        {
        
        }

        public bool MoveNext()
        {
            return false;
        }

        public void Reset()
        {

        }
    }
}
