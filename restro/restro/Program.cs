﻿using System;
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
            Menu summerMenu = new Menu();
            summerMenu.name = "Indian collection";
            summerMenu.addItems("Thali", "Thali can be more effecient", 100);
            summerMenu.addItems("Rajma chawal", "Single item", 60);
            summerMenu.addItems("Cholle chawal", "Single item", 60);

            //Drink menu
            Menu drinkable = new Menu();
            drinkable.name = "Mock tail";
            drinkable.addItems("Lemon", "Lemon drink", 120.5);
            drinkable.addItems("Mango", "Mango drink", 120.5);
            drinkable.addItems("Orange", "Orange drink", 120.5);
        }
    }
}
