using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternLearning.StategyPattern
{
    public interface IFlyBehavior
    {
        void Fly();
    }

    public class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I can fly with wings!");
        }
    }

    public class FlyNoWay : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Sorry, I can't fly.");
        }
    }
}
