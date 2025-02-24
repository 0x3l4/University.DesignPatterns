using University.DesignPatterns.Strategy;

namespace University.DesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Duck[] ducks = 
            {
                new RedHeadDuck(),
                new RubberDuck()
            };

            foreach (var duck in ducks)
            {
                duck.Display();
                duck.Swim();
                duck.Quack();
                duck.Fly();
            }
        }
    }
}
