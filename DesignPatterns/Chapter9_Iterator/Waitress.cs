using System;

namespace Chapter9_Iterator
{
    public class Waitress
    {
        MenuComponent _allMenus;

        public Waitress(MenuComponent menus)
        {
            _allMenus = menus;
        }

        public void PrintMenu()
        {
            _allMenus.Print();
        }

        public void PrintVegetarianMenu()
        {
            var iterator = _allMenus.CreateIterator();
            Console.WriteLine("\nVEGETARIAN MENU\n----");
            while (iterator.MoveNext())
            {
                var component = iterator.Current;
                try
                {
                    if (component != null && component.IsVegeterian())
                    {
                        component.Print();
                    }
                }
                catch 
                {

                }
            }
        }
    }
}
