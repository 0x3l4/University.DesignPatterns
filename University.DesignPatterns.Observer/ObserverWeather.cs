using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.DesignPatterns.Observer
{
    public abstract class ObserverWeather
    {
        protected Subject _weatherData;

        public ObserverWeather(Subject weatherData)
        {
            _weatherData = weatherData;
        }

        public void Subscribe()
        {
            _weatherData.RegisterObserver(this);
        }

        public void Unsubscribe()
        {
            _weatherData.UnregisterObserver(this);
        }

        public abstract void Update(float temperature, float humidity, float pressure);
    }
}
