using System;
namespace ObserverPattern.Properties
{
    abstract class Observer
    {
        public abstract void notify(String message);
    }
}
