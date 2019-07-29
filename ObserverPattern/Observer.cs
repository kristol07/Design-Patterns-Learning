using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternLearning.ObserverPattern
{
    public interface Observer
    {
        void Update(double temp, double humidity, double pressure);
    }

    public class CurrentConditionsDisplay : Observer, DisplayElement
    {
        private double temperature;
        private double humidity;
        private double pressure;
        private ISubject weatherData;

        public CurrentConditionsDisplay(ISubject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Update(double temperature, double humidity, double pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            Display();
        }

        public void Display()
        {
            Console.WriteLine($"Current conditions: {temperature}F degrees, {humidity}% humidity.");
        }
    }
}
