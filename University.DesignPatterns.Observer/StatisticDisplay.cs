using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.DesignPatterns.Observer
{
    public class StatisticDisplay :
        ObserverWeather,
        IDisplayElement
    {
        private List<float> _temperature;
        private int _countMeasurements;

        public StatisticDisplay(Subject weatherData, int countMeassurements = 24) : base(weatherData)
        {
            _temperature = new List<float>();
            _countMeasurements = countMeassurements;
        }

        public void Display()
        {
            if (_countMeasurements <= 0)
            {
                Console.WriteLine("No statistics!");
                return;
            }
            Console.WriteLine(new string('=', Console.BufferWidth));
            Console.WriteLine("Statistic:");
            Console.WriteLine($"Avg temperature: {_temperature.Average()}");
            Console.WriteLine($"Max temperature: {_temperature.Max()}");
            Console.WriteLine($"Min temperature: {_temperature.Min()}");
            Console.WriteLine(new string('=', Console.BufferWidth));
        }

        public override void Update(float temperature, float humidity, float pressure)
        {
            _temperature.Add(temperature);
            Display();
        }
    }
}
