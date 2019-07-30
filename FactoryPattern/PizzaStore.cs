using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternLearning.FactoryPattern
{
    //public class PizzaStore
    //{
    //    protected SimplePizzaFactory factory;

    //    public PizzaStore(SimplePizzaFactory factory)
    //    {
    //        this.factory = factory;
    //    }

    //    public Pizza OrderPizza(string type)
    //    {
    //        Pizza pizza = factory.CreatePizza(type);

    //        pizza.Prepare();
    //        pizza.Bake();
    //        pizza.Cut();
    //        pizza.Box();

    //        return pizza;
    //    }
    //}

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
            switch (type)
            {
                case "cheese":
                    return new NYStyleCheesePizza();
                case "pepperoni":
                    return new NYStylePepperoniPizza();
                case "clam":
                    return new NYStyleClamPizza();
                default:
                    return new NYStyleVeggiePizza();
            }
        }
    }
}
