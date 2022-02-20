using System;
using System.Collections.Generic;
using System.Text;

namespace LOR.Pizzeria
{
    public abstract class Pizza
    {
       public void AddToppings(string topping)
        {
            if (topping == "No")
                return;
            var menu = new Menu();
            Console.WriteLine("Added topping.." );
            foreach (var i in menu.addToppings(topping))
            {
                Console.Write(i + " ");
            }
        }
        public abstract void Prepare();
        public abstract void Bake();
        public abstract void Cut();
        public abstract void Box();
        public abstract void PrintReceipt(string location, string pizzaType, string pizzaTopping);
       
    }
}
