using System;

namespace LOR.Pizzeria.PizzaTypes
{
    public class CapriciosaPizza:Pizza
    {
        public string Name { get; set; }

        public override void Prepare()
        {
            var menu = new Menu();
            Console.WriteLine("Preparing " + Name + "...");
            Console.Write("Adding ");
            foreach (var i in menu.getIngredients(Constants.PizzaType.Capriciosa))
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        public override void Bake()
        {
            Console.WriteLine("Baking pizza for 30 minutes at 200 degrees...");
            
        }

        public override void Cut()
        {
           Console.WriteLine("Cutting pizza into 8 slices...");
           
        }

        public override void Box()
        {
            Console.WriteLine("Putting pizza into a nice box...");
        }

        public override void PrintReceipt(string location, string pizzaType, string pizzaTopping)
        {
            var price = new Price();
            if (string.IsNullOrEmpty(pizzaTopping))
            {
                Console.WriteLine("Total price: " + price.getPrice(location, pizzaType));
            }
            else
                Console.WriteLine("Total price: " + (price.getPrice(location, pizzaType) + price.getToppingPrice(location, pizzaTopping)));
        }

    }
}
