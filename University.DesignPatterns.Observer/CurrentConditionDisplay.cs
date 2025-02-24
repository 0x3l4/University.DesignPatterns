using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.DesignPatterns.Observer
{
    public class CurrentConditionDisplay :
        ObserverWeather,
        IDisplayElement
    {
        private float _tempeature;
        private float _humidity;
        private float _pressure;

        public CurrentConditionDisplay(Subject weatherData) : base(weatherData)
        {
        }

        public void Display()
        {
            Console.WriteLine(new string('=', Console.BufferWidth));
            Console.WriteLine("Current condition:");
            Console.WriteLine($"Temperature: {_tempeature}C");
            Console.WriteLine($"Humidity: {_humidity}%");
            Console.WriteLine($"Pressure: {_pressure}mm Hq");
            Console.WriteLine(new string('=', Console.BufferWidth));
        }

        public override void Update(float temperature, float humidity, float pressure)
        {
            _tempeature = temperature;
            _humidity = humidity;
            _pressure = pressure;
            Display();
        }
    }
}
