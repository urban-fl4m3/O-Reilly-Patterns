using System;

namespace Chapter9_Iterator
{
    public class Program
    {
        static void Main(string[] args)
        {
            MenuComponent pancakeHouseMenu = new Menu("PANCAKE HOUSE MENU", "Breakfast");
            MenuComponent dinerMenu = new Menu("DINER MENU", "Lunch");
            MenuComponent cafeMenu = new Menu("CAFE MENU", "Dinner");
            MenuComponent dessertMenu = new Menu("DESSERT MENU", "Dessert of cource!");

            MenuComponent allMenus = new Menu("ALL MENUS", "All menus combined");
            allMenus.Add(pancakeHouseMenu);
            allMenus.Add(dinerMenu);
            allMenus.Add(cafeMenu);

            dinerMenu.Add(new MenuItem(
                "Pasta",
                "Spaghetti with Marinara Sauce, and a slice of sourdough bread",
                true,
                3.89d));

            dinerMenu.Add(dessertMenu);

            pancakeHouseMenu.Add(new MenuItem("K&B's Pancake Breakfast",
               "Pancakes with scrambled eggs, and toast",
               true,
               2.99d));

            pancakeHouseMenu.Add(new MenuItem("Regular Pancake Breakfast",
                "Pancakes with fried eggs, sausage",
                false,
                2.99d));

            pancakeHouseMenu.Add(new MenuItem("Blueberry Pancakes",
                "Pancakes made with fresh blueberries",
                true,
                3.49d));

            pancakeHouseMenu.Add(new MenuItem("Waffles",
                "Waffles, with your choice of blueberries or strawberries",
                true,
                3.59d));

            dinerMenu.Add(new MenuItem("Vegeterian BLT",
               "(Fakin') Bacon with lettuce & tomato on whole whheat",
               true,
               2.99d));

            dinerMenu.Add(new MenuItem("BLT",
                "Bacon with lettuce & tomato on whole wheat",
                false,
                2.99d));

            dinerMenu.Add(new MenuItem("Soup of the day",
                "Soup of the day, with a side of potato salad",
                false,
                3.29d));

            dinerMenu.Add(new MenuItem("Hotdog",
                "A hot dog with saurkraut, relish, onionsm topped with cheese",
                false,
                3.05d));

            dessertMenu.Add(new MenuItem(
                "Apple pie",
                "Apple pie with a flakey crust, topped with vanilla icecream",
                true,
                1.59d));

            cafeMenu.Add(new MenuItem("Veggie Burger and Air Fries",
              "Veggie burger on a whole wheat bun, lettuce, tomato, and fries",
              true,
              3.99d));

            cafeMenu.Add(new MenuItem("Soup of the day",
                "A cup of the soup of the day, with a side salad",
                false,
                3.69d));

            cafeMenu.Add(new MenuItem("Burrito",
                "A large burrito, with whole pinto beans, salsa, guacamole",
                true,
                4.29d));


            Waitress waitress = new Waitress(allMenus);
            waitress.PrintMenu();
            waitress.PrintVegetarianMenu();

            Console.ReadKey();
        }
    }
}
