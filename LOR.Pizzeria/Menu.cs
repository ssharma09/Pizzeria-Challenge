using System;
using System.Collections.Generic;
using System.Text;

namespace LOR.Pizzeria
{
    public class Menu 
    {
        public List<Tuple<string, string, decimal>> buildMenu(string location)
        {
            Price price = new Price();

            List<Tuple<string, string, decimal>> pizzaName = new List<Tuple<string, string, decimal>>();
            switch (location)
            {
                case Constants.Location.Brisbane:
                    pizzaName.Add(Tuple.Create(Constants.PizzaType.Capriciosa, "mushrooms, cheese, ham, mozarella", price.getPrice(location, Constants.PizzaType.Capriciosa)));
                    pizzaName.Add(Tuple.Create(Constants.PizzaType.Florenza, "olives, pastrami, mozarella, onion", price.getPrice(location, Constants.PizzaType.Florenza)));
                    pizzaName.Add(Tuple.Create(Constants.PizzaType.Margherita, "mozarella, onion, garlic, oregano", price.getPrice(location, Constants.PizzaType.Margherita)));
                    break;
                case Constants.Location.Sydney:
                    pizzaName.Add(Tuple.Create(Constants.PizzaType.Capriciosa, "mushrooms, cheese, ham, mozarella", price.getPrice(location, Constants.PizzaType.Capriciosa)));
                    pizzaName.Add(Tuple.Create(Constants.PizzaType.Inferno, "chili peppers, mozzarella, chicken, cheese", price.getPrice(location, Constants.PizzaType.Inferno)));
                    break;
                case Constants.Location.GoldCoast:
                    pizzaName.Add(Tuple.Create(Constants.PizzaType.Margherita, "mozarella, onion, garlic, oregano", price.getPrice(location, Constants.PizzaType.Margherita)));
                    break;
            }

            return pizzaName;
        }

        public List<string> getIngredients(string pizzaType)
        {
            var ingredients = new List<string>();
            switch (pizzaType)
            {
                case Constants.PizzaType.Capriciosa:
                    ingredients.Add("mushrooms, cheese, ham, mozarella");
                    break;
                case Constants.PizzaType.Florenza:
                    ingredients.Add("olives, pastrami, mozarella, onion");
                    break;
                case Constants.PizzaType.Margherita:
                    ingredients.Add("mozarella, onion, garlic, oregano");
                    break;
                case Constants.PizzaType.Inferno:
                    ingredients.Add("chili peppers, mozzarella, chicken, cheese");
                    break;
            }

            return ingredients;
        }


        public List<string> addToppings(string toppingsToAdd)
        {
            var toppings = new List<string>();

            switch (toppingsToAdd)
            {
                case Constants.Toppings.ExtraCheese:
                    toppings.Add(Constants.Toppings.ExtraCheese);
                    break;
                case Constants.Toppings.OliveOil:
                    toppings.Add(Constants.Toppings.OliveOil);
                    break;
                case Constants.Toppings.Mayo:
                    toppings.Add(Constants.Toppings.Mayo);
                    break;
            }
            return toppings;
        }

        public List<Tuple<string, decimal>> buildToppings(string location)
        {
            Price price = new Price();

            List<Tuple<string,decimal>> pizzaTopping = new List<Tuple<string,decimal>>();
            switch (location)
            {
                case Constants.Location.Brisbane:
                    pizzaTopping.Add(Tuple.Create(Constants.Toppings.OliveOil, price.getToppingPrice(location, Constants.Toppings.OliveOil)));
                    pizzaTopping.Add(Tuple.Create(Constants.Toppings.ExtraCheese, price.getToppingPrice(location, Constants.Toppings.ExtraCheese)));
                    pizzaTopping.Add(Tuple.Create(Constants.Toppings.Mayo, price.getToppingPrice(location, Constants.Toppings.Mayo)));
                    break;
                case Constants.Location.Sydney:
                    pizzaTopping.Add(Tuple.Create(Constants.Toppings.OliveOil, price.getToppingPrice(location, Constants.Toppings.OliveOil)));
                    pizzaTopping.Add(Tuple.Create(Constants.Toppings.Mayo, price.getToppingPrice(location, Constants.Toppings.Mayo)));
                    break;
                case Constants.Location.GoldCoast:
                    pizzaTopping.Add(Tuple.Create(Constants.Toppings.ExtraCheese, price.getToppingPrice(location, Constants.Toppings.ExtraCheese)));
                    pizzaTopping.Add(Tuple.Create(Constants.Toppings.Mayo, price.getToppingPrice(location, Constants.Toppings.Mayo)));
                    break;
            }
            return pizzaTopping;
        }
    }
}
