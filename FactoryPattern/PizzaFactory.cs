using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternLearning.FactoryPattern
{
    public class SimplePizzaFactory
    {
        public Pizza CreatePizza(string type)
        {
            Pizza pizza = null;

            switch (type)
            {
                case "cheese":
                    pizza = new CheesePizza();
                    break;
                case "pepperoni":
                    pizza = new PepperoniPizza();
                    break;
                case "clam":
                    pizza = new ClamPizza();
                    break;
                default:
                    pizza = new VeggiePizza();
                    break;
            }

            return pizza;
        }
    }
}
