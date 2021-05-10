using System;

namespace Chapter2_Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData wd = new WeatherData();

            CurrentConditionDisplay currentDisplay = new CurrentConditionDisplay(wd);

            wd.SetMeasurements(80, 65, 30.4f);
            wd.SetMeasurements(82, 70, 29.2f);
            wd.SetMeasurements(78, 90, 29.2f);

            Console.ReadKey();
        }
    }
}
