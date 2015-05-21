using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restro
{
    public class Menu
    {
        public string name;
        public List<MenuItems> items = new List<MenuItems>();
        public void addItems(string name, string desc, double price) 
        {
            MenuItems item = new MenuItems();
            item.name = name;
            item.description = desc;
            item.price = price;
            items.Add(item);
        }
    }
}
