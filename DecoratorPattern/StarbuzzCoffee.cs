using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternLearning.DecoratorPattern
{
    public abstract class Beverage
    {
        public string description = "Unknown Beverage";

        public string GetDescription()
        {
            return description;
        }

        public abstract double Cost();
    }

    public abstract class CondimentDecorator : Beverage
    {
        public abstract string GetDescription();
    }

    public class Espresso : Beverage
    {
        public Espresso()
        {
            description = "Espresso";
        }
        public override double Cost()
        {
            return 1.99;
        }
    }

    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            description = "HouseBlend";
        }

        public override double Cost()
        {
            return 0.89;
        }
    }

    public class Mocha : CondimentDecorator
    {
        Beverage beverage;

        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Mocha";
        }

        public override double Cost()
        {
            return 0.20 + beverage.Cost();
        }
    }
}
