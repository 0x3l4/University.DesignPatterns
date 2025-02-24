using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.DesignPatterns.Strategy
{
    public class RedHeadDuck : Duck
    {
        public RedHeadDuck() : base(new FlyWithWings(), new QuackCommon()) 
        {
            
        }

        public override void Display()
        {
            Console.WriteLine("Я - Красноголовая утка!");
        }
    }
}
