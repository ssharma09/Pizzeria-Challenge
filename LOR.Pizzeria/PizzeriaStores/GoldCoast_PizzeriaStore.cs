using System;
using System.Collections.Generic;
using LOR.Pizzeria.PizzaTypes;

namespace LOR.Pizzeria.PizzeriaStores
{
    public class GoldCoast_PizzeriaStore : PizzeriaStore
    {
        public GoldCoast_PizzeriaStore()
        {
            location = Constants.Location.GoldCoast;
        }
     
        public override Pizza CreatePizza(string pizzaType)
        {
            return pizzaType switch
            {
                Constants.PizzaType.Inferno => new InfernoPizza(),
                _ => null
            };
        }

        public override bool IsPizzaTypeAvailable(string pizzaType)
        {
            var pizzaTypeAvailable = new List<string>();
            pizzaTypeAvailable.Add(Constants.PizzaType.Inferno);

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
            throw new NotImplementedException();
        }
    }
}