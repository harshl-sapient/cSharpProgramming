using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restro
{
    public class order 
    {
        public List<MenuItems> items = new List<MenuItems>();

        public double calculatedPrice;

        public double totalPrice()
        {
            foreach (MenuItems item in items)
            {
                calculatedPrice += item.price;
            }

            return calculatedPrice;
        }
    }
}
