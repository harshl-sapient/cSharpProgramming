using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinnerMenu
{
    class Menu
    {
        //Constructor that will instantiate menu item
        public Menu() { 
            items = new List<MenuItem>();
        }
        public string title;
        //Creating a bucket to hold on item list
        public List<MenuItem> items;
    }
}
