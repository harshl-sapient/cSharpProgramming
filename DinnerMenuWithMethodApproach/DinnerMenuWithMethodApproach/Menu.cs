using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinnerMenuWithMethodApproach
{
    class Menu
    {
        public Menu() {
            items = new List<MenuItem>();
        }
        public string title;
        public List<MenuItem> items;
        public void addItemInMenu (string name, string description, double price){
            MenuItem item = new MenuItem();
            item.name = name;
            item.description = description;
            item.price = price;
            items.Add(item);
        }
    }
}
