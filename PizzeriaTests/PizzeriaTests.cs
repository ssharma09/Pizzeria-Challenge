using LOR.Pizzeria;
using LOR.Pizzeria.PizzeriaStores;
using NUnit.Framework;

namespace PizzeriaTests
{
    public class Tests
    {
        Brisbane_PizzeriaStore brisStore = new Brisbane_PizzeriaStore();
        Sydney_PizzeriaStore sydneyStore = new Sydney_PizzeriaStore();
        GoldCoast_PizzeriaStore goldCoastStore = new GoldCoast_PizzeriaStore();
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void BrisbaneOrderMargheritaPizzaAvailableWithTopping()
        {
           brisStore.orderPizza(Constants.PizzaType.Margherita, Constants.Toppings.ExtraCheese);
        }
        [Test]
        public void BrisbaneOrderInfernoPizzaNoAvailable()
        {
            brisStore.orderPizza(Constants.PizzaType.Inferno, "No");
        }
        [Test]
        public void SydneyOrderCapriciosaInfernoPizzaAvailable()
        {
            sydneyStore.orderPizza(Constants.PizzaType.Capriciosa, "No");
            sydneyStore.orderPizza(Constants.PizzaType.Inferno, Constants.Toppings.Mayo);

        }

        [Test]
        public void GoldCoastOrderInfernoPizzaBakingTimeUpdate45Mins180Degree()
        {
            goldCoastStore.orderPizza(Constants.PizzaType.Inferno, "No");
        }
    }
}