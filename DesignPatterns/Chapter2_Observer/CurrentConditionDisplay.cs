using System;

namespace Chapter2_Observer
{
    public class CurrentConditionDisplay : IObserver, IDisplay
    {
        private float _temperature;
        private float _humidity;
        private ISubject _weatherData;

        public CurrentConditionDisplay(ISubject weatherData)
        {
            _weatherData = weatherData;
            _weatherData.Register(this);
        }

        public void Display()
        {
            Console.WriteLine($"Current conditions: {_temperature}F degrees and {_humidity}% humidity.");
        }

        public void Update(float temp, float humidity, float pressure)
        {
            _temperature = temp;
            _humidity = humidity;
            Display();
        }
    }
}
