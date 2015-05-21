using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Removed as this section is being done by method
            //MenuItems summerMenuItems = new MenuItems();
            //summerMenuItems.name = "Indian";
            //summerMenuItems.description = "Things u can eat";
            //summerMenuItems.price = 100;
            //Eatables
            //Menu summerMenu = new Menu();
            //summerMenu.name = "Indian collection";
            //summerMenu.addItems("Thali", "Thali can be more effecient", 100);
            //summerMenu.addItems("Rajma chawal", "Single item", 60);
            //summerMenu.addItems("Cholle chawal", "Single item", 60);

            ////Drink menu
            //Menu drinkable = new Menu();
            //drinkable.name = "Mock tail";
            //drinkable.addItems("Lemon", "Lemon drink", 120.5);
            //drinkable.addItems("Mango", "Mango drink", 120.5);
            //drinkable.addItems("Orange", "Orange drink", 120.5);

            //Inheritance concept
            disclaimer summerMenu = new disclaimer();
            summerMenu.name = "Indian Collection";
            summerMenu.addItems("Thali", "Thali can be more effecient", 100);
            summerMenu.addItems("Rajma chawal", "Single item", 60);
            summerMenu.addItems("Cholle chawal", "Single item", 60);
            summerMenu.disName = "Go to hospital. Can find way to hospital on reception";

            disclaimer drinkable = new disclaimer();
            drinkable.name = "Mock tail";
            drinkable.addItems("Lemon", "Lemon drink", 120.5);
            drinkable.addItems("Mango", "Mango drink", 120.5);
            drinkable.addItems("Orange", "Orange drink", 120.5);
            drinkable.disName = "We are not responsible for your health";

            //Now taking order - Lets assume everything is ordered by a hunger man
            order hungerOrder = new order();
            for (int x = 0; x < summerMenu.items.Count; x++) {
                MenuItems currentItem = summerMenu.items[x];
                hungerOrder.items.Add(currentItem);
            }
            foreach (MenuItems currentItem in drinkable.items)
            {
                hungerOrder.items.Add(currentItem);
            }

            Console.WriteLine("The total price order " + hungerOrder.totalPrice());
            Console.ReadKey();

        }
    }
}
