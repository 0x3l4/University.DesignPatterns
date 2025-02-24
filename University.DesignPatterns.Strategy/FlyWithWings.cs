using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.DesignPatterns.Strategy
{
    public class FlyWithWings : FlyBehahaviour
    {
        public override void Fly()
        {
            Console.WriteLine("Лечу на крыльях!");
        }
    }
}
