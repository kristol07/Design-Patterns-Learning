using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternLearning.StategyPattern
{
    public abstract class Duck
    {
        protected IQuackBehavior quackBehavior;
        protected IFlyBehavior flyBehavior;

        public void PerformQuack()
        {
            quackBehavior.Quack();
        }

        public void PerformFly()
        {
            flyBehavior.Fly();
        }

        public void Swim()
        {
            Console.WriteLine("All ducks float, even decoys!");
        }

        public abstract void Display();
        
    }

    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            quackBehavior = new QuackNormal();
            flyBehavior = new FlyWithWings();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a real Mallard duck.");
        }
    }
}
