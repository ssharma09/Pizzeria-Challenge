using System;
using System.Collections.Generic;
using System.Text;

namespace LOR.Pizzeria
{
    public class Price
    {
        public decimal basePrice { get; set; }

        public decimal toppingPrice { get; set; }

        public decimal getPrice(string location, string pizzaType)
        {
            basePrice = location switch
            {
                Constants.Location.Brisbane => pizzaType switch
                {
                    Constants.PizzaType.Capriciosa => 20,
                    Constants.PizzaType.Florenza => 21,
                    Constants.PizzaType.Margherita => 22,
                    _ => basePrice
                },
                Constants.Location.Sydney => pizzaType switch
                {
                    Constants.PizzaType.Capriciosa => 30,
                    Constants.PizzaType.Inferno => 31,
                    _ => basePrice
                },
                Constants.Location.GoldCoast => pizzaType switch
                {
                    Constants.PizzaType.Inferno => 35,
                    _ => basePrice
                },
                _ => basePrice
            };

            return basePrice;
        }

        public decimal getToppingPrice(string location, string topping)
        {
            toppingPrice = location switch
            {
                Constants.Location.Brisbane => topping switch
                {
                    Constants.Toppings.OliveOil => 2,
                    Constants.Toppings.Mayo => 1,
                    Constants.Toppings.ExtraCheese => 2,
                    _ => toppingPrice
                },
                Constants.Location.Sydney => topping switch
                {
                    Constants.Toppings.OliveOil => 1,
                    Constants.Toppings.Mayo => 3,
                    _ => toppingPrice
                },
                Constants.Location.GoldCoast => topping switch
                {
                    Constants.Toppings.Mayo => 2,
                    Constants.Toppings.ExtraCheese => 3,
                    _ => toppingPrice
                },
                _ => toppingPrice
            };

            return toppingPrice;
        }
    }
}
