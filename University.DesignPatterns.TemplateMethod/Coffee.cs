﻿namespace University.DesignPatterns.TemplateMethod
{
    /// <summary>
    /// Способы приготовления чая и кофе имеет много общего
    /// 1 - рецепт кофе: а) вскипятить воду, б) заварить кофе в горячей воде, в) перелить кофе в чашку
    /// д) добавить сахара и молока
    /// 2 - рецепт чая: а) вскипятить воду, б) заварить чай в горячей воде, в) перелить чай в чашку
    /// д) добавить лимон
    /// Классы чая и кофе содержат дублированный код. Чтобы избавиться от этого, можно
    /// построить соотвествующую иерархию: (аблстрактный класс напитка с BoilWater и PourInCup)
    /// На самом деле, оба рецепта следуют общему алгоритму:
    /// а) вскипятить воду, б) использовать горячую воду для настаивания кофе или чая
    /// в) перелить напиток в чашку, д) добавить соответсвующие дополнения
    /// Данный код реализует паттерн "Шаблонный метод". Шаблонный метод определяет
    /// шаги алгоритма и представляется классам осуществлять реализацию одного или нескольких шагов.
    /// В примере шаблонным методом является PrepareRecipe
    /// </summary>
    public class Coffee : CaffeineBeverage
    {
        protected override void Drew()
        {
            Console.WriteLine("Dripping Coffee through filter");
        }

        protected override void AddCondiments()
        {
            Console.WriteLine("Adding Suqar and Milk");
        }
    }
}
