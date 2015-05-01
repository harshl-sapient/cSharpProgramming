using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinnerMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu vegetables = new Menu();
            vegetables.title = "Vegie";
            MenuItem vegitems = new MenuItem();
            vegitems.Name = "Tomato";
            vegitems.Description = "Sweet in taste";
            vegitems.price = 12.2;
            vegetables.items.Add(vegitems);
        }
    }
}
