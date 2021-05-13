using System;

namespace Chapter9_Iterator
{
    public class Waitress
    {
        private readonly IIterable _pancakeHouseMenu;
        private readonly IIterable _dinerMenu;

        public Waitress(IIterable pancakeHouseMenu, IIterable dinerMenu)
        {
            _pancakeHouseMenu = pancakeHouseMenu;
            _dinerMenu = dinerMenu;
        }

        public void PrintMenu()
        {
            IIterator dinerIterator = _dinerMenu.CreateIterator();
            IIterator pancakeIterator = _pancakeHouseMenu.CreateIterator();
            Console.WriteLine("MENU\n----\nBREAKFAST");
            PrintMenu(pancakeIterator);
            Console.WriteLine("\nLUNCH");
            PrintMenu(dinerIterator);
        }

        private void PrintMenu(IIterator iterator)
        {
            while (iterator.HasNext())
            {
                MenuItem menuItem = (MenuItem)iterator.Next();
                Console.WriteLine($"{menuItem.Name}, {menuItem.Price} -- {menuItem.Description}");
            }
        }
    }
}
