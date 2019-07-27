using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternLearning.ObserverPattern
{
    public class WeatherData: Subject
    {
        public double temperature;
        public double humidity;
        public double pressure;
        public List<Observer> observers = new List<Observer>();

        //public double getTemperature() { return temperature; }
        //public double getHumidity() { return humidity; }
        //public double getPressure() { return pressure; }

        public void measurementsChanged()
        {
            NotifyObservers();
        }

        // mock new measurements from weather station
        public void Setmeasurements(double temperature, double humidity, double pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            measurementsChanged();
        }

        public void RegisterObserver(Observer o)
        {
            observers.Add(o);
        }

        public void RemoveObserver(Observer o)
        {
            if (observers.Contains(o))
            {
                observers.Remove(o);
            }
        }

        public void NotifyObservers()
        {
            foreach (Observer o in observers)
            {
                o.Update(temperature, humidity, pressure);
            }
        }
    }
}
