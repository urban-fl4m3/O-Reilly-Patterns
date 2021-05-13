using System;
using System.Collections.Generic;

namespace Chapter9_Iterator
{
    public abstract class MenuComponent
    {
        public virtual void Add(MenuComponent component)
        {
            throw new NotImplementedException();
        }

        public virtual void Remove(MenuComponent component)
        {
            throw new NotImplementedException();
        }

        public virtual MenuComponent GetChild(int i)
        {
            throw new NotImplementedException();
        }

        public virtual string GetName()
        {
            throw new NotImplementedException();
        }

        public virtual string GetDescription()
        {
            throw new NotImplementedException();
        }

        public virtual double GetPrice()
        {
            throw new NotImplementedException();
        }

        public virtual bool IsVegeterian()
        {
            throw new NotImplementedException();
        }

        public virtual void Print()
        {
            throw new NotImplementedException();
        }

        public virtual IEnumerator<MenuComponent> CreateIterator()
        {
            throw new NotImplementedException();
        }
    }
}
