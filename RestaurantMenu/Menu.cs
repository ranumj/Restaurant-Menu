using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantMenu
{
    public class Menu
    {
        // Declare List to Store Menu Items
       private List<MenuItem> MenuItems;
        public Menu()
        {
            this.MenuItems = new List<MenuItem>();
        }

        // Method to Add Items to List
       /*public void AddItem(double price, string description , string category)
        {
            MenuItem AddedItem = new MenuItem(price, description, category);
            MenuItems.Add(AddedItem);
        }*/

        // New Method to Add Items to List
        public void AddItem(MenuItem item)
        {
            MenuItems.Add(item);
            foreach (MenuItem existingItem in MenuItems)
            {
                if (item.ItemDescription.ToLower() == existingItem.ItemDescription.ToLower())
                {
                    throw new Exception("Item already exists in the Menu");
                }
            }
        }

        // Method to Remove Item from List
        public void RemoveItem(MenuItem item)
        {
            MenuItems.Remove(item);
        }

        // Method to Print Item in List
        public void PrintItems()
        {
            foreach(MenuItem menuItem in MenuItems)
            {
                Console.WriteLine($"{menuItem.ItemCategory} | {menuItem.ItemDescription} | {menuItem.ItemPrice} | {menuItem.itemDateTime}");
            }
        }
    }
}
