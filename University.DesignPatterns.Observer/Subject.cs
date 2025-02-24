using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.DesignPatterns.Observer
{
    public abstract class Subject
    {
        protected List<ObserverWeather> _observers;

        public Subject()
        {
            _observers = new List<ObserverWeather>();
        }

        public void RegisterObserver(ObserverWeather observer)
        {
            _observers.Add(observer);
        }

        public bool UnregisterObserver(ObserverWeather observer)
        {
            return _observers.Remove(observer);
        }

        public abstract void NotifyObservers();
    }
}
