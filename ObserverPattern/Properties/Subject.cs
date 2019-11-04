using System;

namespace ObserverPattern.Properties
{
    abstract class Subject
    {
        public abstract void Register(Observer observer);

        public abstract void Remove(Observer observer);

        public abstract void Notify(string message);
    }
}
