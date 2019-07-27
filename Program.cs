using DesignPatternLearning.StategyPattern;
using DesignPatternLearning.ObserverPattern;
using System;

namespace DesignPatternLearning
{
    public class Program
    {
        static void Main(string[] args)
        {

            //// Strategy Pattern
            //Duck duck = new MallardDuck();
            //duck.PerformQuack();
            //duck.PerformFly();
            //duck.Display();

            // Observer Pattern
            WeatherData weatherData = new WeatherData();
            CurrentConditionsDisplay currentConditionsDisplay = new CurrentConditionsDisplay(weatherData);

            weatherData.Setmeasurements(80, 65, 30.4);
            weatherData.Setmeasurements(82, 70, 29.2);

        }
    }
}
