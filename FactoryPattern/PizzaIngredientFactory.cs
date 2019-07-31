using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternLearning.FactoryPattern
{
    public interface PizzaIngredientFactory
    {
        public Dough CreateDough();
        public Sauce CreateSauce();
        public Cheese CreateCheese();
        public List<Veggie> CreateVeggies();
        public Pepperoni CreatePepperoni();
        public Clams CreateClam();
    }

    public class NYPizzaIngredientFactory : PizzaIngredientFactory
    {
        public Dough CreateDough()
        {
            return new ThinCrustDough();
        }

        public Sauce CreateSauce()
        {
            return new MarinaraSauce();
        }

        public Cheese CreateCheese()
        {
            return new ReggianoCheese();
        }

        public List<Veggie> CreateVeggies()
        {
            List<Veggie> veggies = new List<Veggie>({ new Garlic(), new Onion(), new Mushroom(), new RedPepper() });
            return veggies;
        }

        public Pepperoni CreatePepperoni()
        {
            return new SlicedPepperoni();
        }

        public Clams CreateClam()
        {
            return new FreshClams();
        }
    }
}
