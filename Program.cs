using DesignPatternLearning.StategyPattern;
using DesignPatternLearning.ObserverPattern;
using DesignPatternLearning.DecoratorPattern;
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

            //// Observer Pattern
            //WeatherData weatherData = new WeatherData();
            //CurrentConditionsDisplay currentConditionsDisplay = new CurrentConditionsDisplay(weatherData);

            //weatherData.Setmeasurements(80, 65, 30.4);
            //weatherData.Setmeasurements(82, 70, 29.2);

            //// Decorator Pattern Example 1
            //Beverage beverage = new Espresso();
            //Console.WriteLine($"{beverage.GetDescription()}: $ {beverage.Cost()}");
            //beverage = new Mocha(beverage);
            //Console.WriteLine($"{beverage.GetDescription()}: $ {beverage.Cost()}");

            // Decorator Pattern Example 2
            Book book = new Book("Worley", "Inside ASP.NET", 10);
            book.Display();
            Borrowable borrowbook = new Borrowable(book);
            borrowbook.BorrowItem("Customer #1");
            borrowbook.BorrowItem("Customer #2");
            borrowbook.Display();

        }
    }
}
