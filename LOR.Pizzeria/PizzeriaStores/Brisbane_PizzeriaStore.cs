using System;
using System.Collections.Generic;
using LOR.Pizzeria.PizzaTypes;

namespace LOR.Pizzeria.PizzeriaStores
{
    public class Brisbane_PizzeriaStore : PizzeriaStore
    {
        public  Brisbane_PizzeriaStore()
        {
            location = Constants.Location.Brisbane;
        }

        public override Pizza CreatePizza(string pizzaType)
        {
            return pizzaType switch
            {
                Constants.PizzaType.Capriciosa => new CapriciosaPizza(),
                Constants.PizzaType.Florenza => new FlorenzaPizza(),
                Constants.PizzaType.Margherita => new MargheritaPizza(),
                _ => null
            };
        }

        public override bool IsPizzaTypeAvailable(string pizzaType)
        {
            var pizzaTypeAvailable = new List<string>();
            pizzaTypeAvailable.Add(Constants.PizzaType.Capriciosa);
            pizzaTypeAvailable.Add(Constants.PizzaType.Florenza);
            pizzaTypeAvailable.Add(Constants.PizzaType.Margherita);

            return (pizzaTypeAvailable.Contains(pizzaType));
        }

        public override void LoadMenu()
        {
            var menu = new Menu();

            
            var menuList = menu.buildMenu(location);

            foreach (var item in menuList)
            {
                Console.WriteLine(item);
            }
            
        }

        public override void LoadToppings()
        {
            var menu = new Menu();

            var toppingsList = menu.buildToppings(location);

            foreach (var item in toppingsList)
            {
                Console.WriteLine(item);
            }

        }


    }
}