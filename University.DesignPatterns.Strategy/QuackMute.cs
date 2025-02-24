using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.DesignPatterns.Strategy
{
    public class QuackMute : QuackBehaviour
    {
        public override void Quack()
        {
            Console.WriteLine("Не могу крякать!");
        }
    }
}
