using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.DesignPatterns.Strategy
{
    public class RubberDuck : Duck
    {
        public RubberDuck() : base(new FlyNoWay(), new QuackSqueaky())
        {

        }

        public override void Display()
        {
            Console.WriteLine("Я - Резиновая утка!");
        }
    }
}
