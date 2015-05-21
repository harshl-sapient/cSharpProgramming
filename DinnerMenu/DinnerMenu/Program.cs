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
            vegetables.AddMenuItem("Tomoato", "Sweet in taste", 60);
            vegetables.AddMenuItem("Mix Veg", "Good with health", 100);

            DrinkMenu mocktail = new DrinkMenu();
            mocktail.AddMenuItem("Lemon", "Sour with Lemon taste", 100.23);
            mocktail.AddMenuItem("Chilled chilly", "chilly in taste", 120);
            mocktail.disclaimer = "Go to reception if you feel sick";

            //Instantiate
            Order hungryAnkit = new Order();

            for (int x=0; x < vegetables.items.Count; x++) {
                MenuItem current = vegetables.items[x];
                hungryAnkit.items.Add(current);
            }

            foreach (MenuItem current in mocktail.items)
            {
                hungryAnkit.items.Add(current);
            }
        }
    }
}
