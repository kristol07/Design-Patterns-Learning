using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternLearning.FactoryPattern
{

    public abstract class Pizza
    {
        protected string name;
        protected Dough dough;
        protected Sauce sauce;
        protected List<Veggie> veggies;
        protected Cheese cheese;
        protected Pepperoni pepperoni;
        protected Clams clam;

        public abstract void Prepare();

        public void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }

        public void Cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }

        public void Box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }

        public string GetName()
        {
            return name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

    }

    public class CheesePizza : Pizza
    {
        PizzaIngredientFactory ingredientFactory;

        public CheesePizza(PizzaIngredientFactory ingredientFactory)
        {
            this.ingredientFactory = ingredientFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine("Preparing " + name);
            dough = ingredientFactory.CreateDough();
            sauce = ingredientFactory.CreateSauce();
            cheese = ingredientFactory.CreateCheese();
        }
    }
}
