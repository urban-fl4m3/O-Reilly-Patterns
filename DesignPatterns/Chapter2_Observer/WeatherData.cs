using System.Collections.Generic;

namespace Chapter2_Observer
{
    public class WeatherData : ISubject
    {
        private readonly List<IObserver> _observers = new List<IObserver>();
        private float _temperature;
        private float _humidity;
        private float _pressure;

        public void Register(IObserver o)
        {
            _observers.Add(o);
        }

        public void Unregister(IObserver o)
        {
            _observers.Remove(o);
        }

        public void Notify()
        {
            foreach (var o in _observers)
            {
                o.Update(_temperature, _humidity, _pressure);
            }
        }

        public void MeasuremenersChanged()
        {
            Notify();
        }

        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            _temperature = temperature;
            _humidity = humidity;
            _pressure = pressure;
            MeasuremenersChanged();
        }
    }
}
