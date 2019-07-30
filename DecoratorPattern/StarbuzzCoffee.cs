using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternLearning.DecoratorPattern
{
    public abstract class Beverage
    {
        public string description = "Unknown Beverage";

        public abstract string GetDescription();

        public abstract double Cost();
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

        public override string GetDescription()
        {
            return description;
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

        public override string GetDescription()
        {
            return description;
        }
    }


    public abstract class CondimentDecorator : Beverage
    {

        protected Beverage beverage;

        public CondimentDecorator(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription();
        }
    }

    public class Mocha : CondimentDecorator
    {

        public Mocha(Beverage beverage) : base(beverage) { }

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
