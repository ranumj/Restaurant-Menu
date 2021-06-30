/* June 28, 2021.
 * LaunchCode
 * Chapter 18 Studio: Classes in C#, Part 1
 * Restaurant Menu
 * Julian Munar & Tatyana Pearson
 */

using System;

namespace RestaurantMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nItalian Bistro Menu");
            
            Menu MenuOne = new Menu();
            /*MenuOne.AddItem(8.99, "Mozzarella Sticks", "Appetizer");
            MenuOne.AddItem(10.99, "Calamari", "Appetizer");
            MenuOne.AddItem(17.99, "Fettuccine Alfredo with Chicken", "Main Course");
            MenuOne.AddItem(15.99, "Spaghetti with Meatballs", "Main Course");
            MenuOne.AddItem(5.99, "Tiramisu", "Dessert");
            MenuOne.AddItem(6.99, "Cannoli", "Dessert");*/

            MenuItem vealParm = new MenuItem(19.99, "Veal Parmegiana", "Main Course");
            MenuItem cknPic;
            cknPic = new MenuItem(24.99, "Chicken Piccata", "Main Course");

            MenuItem vealParmTwo = new MenuItem(19.99, "Veal Parmegiana", "Main Course");

            MenuOne.AddItem(vealParm);
            MenuOne.AddItem(cknPic);
            MenuOne.AddItem(vealParmTwo);

            Console.WriteLine("\n");
            MenuOne.PrintItems();

            MenuOne.RemoveItem(vealParm);

            Console.WriteLine("\n");
            MenuOne.PrintItems();

        }
    }
}
