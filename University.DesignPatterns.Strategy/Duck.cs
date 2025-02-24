using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.DesignPatterns.Strategy
{
    public abstract class Duck
    {
        protected FlyBehahaviour? _flyBehahaviour;
        protected QuackBehaviour? _quackBehaviour;

        public Duck(FlyBehahaviour? flyBehahaviour, QuackBehaviour? quackBehaviour)
        {
            _flyBehahaviour = flyBehahaviour;
            _quackBehaviour = quackBehaviour;
        }

        public void Swim()
        {
            Console.WriteLine("Плыву!");
        }

        public void Quack()
        {
            _quackBehaviour?.Quack();
        }

        public void Fly()
        {
            _flyBehahaviour?.Fly();
        }

        public virtual void Display()
        {
            Console.WriteLine("Я - Обычная утка!");
        }
    }
}
