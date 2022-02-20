using System;

namespace LOR.Pizzeria.PizzeriaStores
{
    public abstract class PizzeriaStore
    {
        public string location { get; set; }

        public abstract Pizza CreatePizza(string pizzaType);

        public abstract bool IsPizzaTypeAvailable(string pizzaType);
        public Pizza orderPizza(string pizzaType,string pizzaTopping)
        {
            if (!IsPizzaTypeAvailable(pizzaType))
            {
                Console.WriteLine("Sorry this Pizza is not available");
                return null;
            }
            else
            {
                var pizza = CreatePizza(pizzaType);
                pizza.Prepare();
                pizza.Bake();
                pizza.Cut();
                pizza.Box();
                pizza.AddToppings(pizzaTopping);
                pizza.PrintReceipt(location, pizzaType, pizzaTopping);
               
                return pizza;
            }
        }
        public abstract void LoadMenu();

        public abstract void LoadToppings();

       }

}
