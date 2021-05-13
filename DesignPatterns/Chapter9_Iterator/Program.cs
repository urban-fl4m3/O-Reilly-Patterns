using System;

namespace Chapter9_Iterator
{
    public class Program
    {
        static void Main(string[] args)
        {
            IIterable pancakeHouseMenu = new PancakeHouseMenu();
            IIterable dinerMenu = new DinerMenu();

            Waitress waitress = new Waitress(pancakeHouseMenu, dinerMenu);
            waitress.PrintMenu();

            Console.ReadKey();
        }
    }
}
