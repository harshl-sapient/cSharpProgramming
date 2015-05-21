using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinnerMenu
{
    public class Menu
    {
        //Constructor that will instantiate menu item
        public Menu() { 
            items = new List<MenuItem>();
        }

        public string title;
        //Creating a bucket to hold on item list
        public List<MenuItem> items;

        public void AddMenuItem(string name, string desc, double price) {
            MenuItem item = new MenuItem();
            item.Name = name;
            item.Description = desc;
            item.price = price;
            items.Add(item);
        }
    }
}
