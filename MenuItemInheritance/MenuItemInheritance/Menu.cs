using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuItemInheritance
{
    class Menu
    {
        public Menu() { 
            items = new List<MenuItem>();
        }
        public string title;
        public List<MenuItem> items;
    }
}
