using System.Collections.Generic;

namespace Chapter9_Iterator
{
    public class CompositeIterator : IEnumerator<MenuComponent>
    {
        private Stack<IEnumerator<MenuComponent>> _stack = new Stack<IEnumerator<MenuComponent>>();

        public CompositeIterator(IEnumerator<MenuComponent> iterator)
        {
            _stack.Push(iterator);
        }

        public object Current
        {
            get
            {
                if (MoveNext())
                {
                    var iterator = _stack.Peek();
                    var component = iterator.Current;
                    _stack.Push(component.CreateIterator());
                    return component;
                }
                else
                {
                    return null;
                }
            }
        }

        MenuComponent IEnumerator<MenuComponent>.Current => (MenuComponent) Current;

        public void Dispose()
        {
            _stack.Clear();
        }

        public bool MoveNext()
        {
            if (_stack.Count == 0)
            {
                return false;
            }
            else
            {
                var iterator = _stack.Peek();
                if (!iterator.MoveNext())
                {
                    _stack.Pop();
                    return MoveNext();
                }
                else
                {
                    return true;
                }
            }
        }

        public void Reset()
        {
            throw new System.NotImplementedException();
        }
    }
}
