using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternLearning.StategyPattern
{
    public interface IQuackBehavior
    {
        void Quack();
    }

    public class QuackNormal : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("I can quack.");
        }
    }

    public class Squeak : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("I can squeak.");
        }
    }

    public class MuteQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("I can't quack.");
        }
    }
}
