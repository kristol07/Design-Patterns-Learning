using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternLearning.ObserverPattern
{
    public interface ISubject
    {
        void RegisterObserver(Observer o);

        void RemoveObserver(Observer o);

        void NotifyObservers();
    }
}
