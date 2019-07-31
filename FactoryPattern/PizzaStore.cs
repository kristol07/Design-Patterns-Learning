using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternLearning.FactoryPattern
{
    public abstract class PizzaStore
    {
        public Pizza OrderPizza(string type)
        {
            Pizza pizza = CreatePizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }

        public abstract Pizza CreatePizza(string type);
    }

    public class NYPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string type)
        {
            PizzaIngredientFactory ingredientFactory = new NYPizzaIngredientFactory();

            switch (type)
            {
                case "cheese":
                    Pizza pizza = new CheesePizza(ingredientFactory);
                    pizza.SetName("New York Style Cheese Pizza");
                    return pizza;
                case "veggie":
                    Pizza pizza = new VeggiePizza(ingredientFactory);
                    pizza.SetName("New York Style Veggie Pizza");
                    return pizza;
                default:
                    return new ClamPizza(ingredientFactory);
            }
        }
    }
}
