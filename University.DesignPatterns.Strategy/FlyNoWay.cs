using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.DesignPatterns.Strategy
{
    public class FlyNoWay : FlyBehahaviour
    {
        public override void Fly()
        {
            Console.WriteLine("Не могу летать!");
        }
    }
}
