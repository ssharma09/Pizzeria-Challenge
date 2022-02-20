using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Xml.Schema;
using LOR.Pizzeria.PizzeriaStores;

namespace LOR.Pizzeria
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to LOR Pizzeria! Please select the store location: Brisbane, Sydney OR Gold Coast");
            var Store = Console.ReadLine();

            Console.WriteLine("MENU");

            if (Store == Constants.Location.Brisbane)
            {
                TakePizzaOrder(new Brisbane_PizzeriaStore());
            }
            else if (Store == Constants.Location.Sydney)
            {
               TakePizzaOrder(new Sydney_PizzeriaStore());
            }
            else if (Store == Constants.Location.GoldCoast)
            {
                TakePizzaOrder(new GoldCoast_PizzeriaStore());
            }

            Console.WriteLine("\nYour pizza is ready!");
        }

        public static void TakePizzaOrder(Brisbane_PizzeriaStore brisPizzeriaStore)
        {
            while (true)
            {
                brisPizzeriaStore.LoadMenu();

                Console.WriteLine("What can I get you?");

                var pizzaType = Console.ReadLine();

                Console.WriteLine("Would you like any toppings? Type No if you did not like any toppings");
                brisPizzeriaStore.LoadToppings();

                var pizzaTopping = Console.ReadLine();

                var pizza = brisPizzeriaStore.orderPizza(pizzaType, pizzaTopping);

                Console.WriteLine("Would you like to order another Pizza ? Type Yes, to start again .");

                var orderAgain = Console.ReadLine();

                if (orderAgain == "Yes")
                {
                    brisPizzeriaStore = new Brisbane_PizzeriaStore();
                      
                    continue;
                }
                break;
            }
        }
        public static void TakePizzaOrder(Sydney_PizzeriaStore sydPizzeriaStore)
        {
            while (true)
            {
                sydPizzeriaStore.LoadMenu();

                Console.WriteLine("What can I get you?");

                var pizzaType = Console.ReadLine();

                Console.WriteLine("Would you like any toppings? Type No if you did not like any toppings");
                sydPizzeriaStore.LoadToppings();

                var pizzaTopping = Console.ReadLine();

                Pizza pizza = sydPizzeriaStore.orderPizza(pizzaType, pizzaTopping);

                Console.WriteLine("Would you like to order another Pizza ? Type Yes, to start again .");

                var orderAgain = Console.ReadLine();

                if (orderAgain == "Yes")
                {
                    sydPizzeriaStore = new Sydney_PizzeriaStore();
                    continue;
                }

                break;
            }
        }
        public static void TakePizzaOrder(GoldCoast_PizzeriaStore goldcoastPizzeriaStore)
        {
            while (true)
            {
                goldcoastPizzeriaStore.LoadMenu();

                Console.WriteLine("What can I get you?");

                var pizzaType = Console.ReadLine();

                Console.WriteLine("Would you like any toppings? Type No if you did not like any toppings");
                goldcoastPizzeriaStore.LoadToppings();

                var pizzaTopping = Console.ReadLine();

                Pizza pizza = goldcoastPizzeriaStore.orderPizza(pizzaType, pizzaTopping);

                Console.WriteLine("Would you like to order another Pizza ? Type Yes, to start again .");

                var orderAgain = Console.ReadLine();

                if (orderAgain == "Yes")
                {
                    goldcoastPizzeriaStore = new GoldCoast_PizzeriaStore();
                    continue;
                }

                break;
            }
        }


    }

}
