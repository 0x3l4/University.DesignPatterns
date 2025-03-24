using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.DesignPatterns.TemplateMethod
{
    public abstract class CaffeineBeverage
    {
        public void PrepareRecipe()
        {
            BoilWater();
            Drew();
            PourInCup();
            AddCondiments();
        }
        protected void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }

        protected abstract void Drew();
        protected void PourInCup()
        {
            Console.WriteLine("Pouring into cup");
        }
        protected abstract void AddCondiments();

    }
}
