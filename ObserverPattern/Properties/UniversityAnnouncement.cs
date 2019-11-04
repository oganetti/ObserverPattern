using System;
using System.Collections.Generic;

namespace ObserverPattern.Properties
{
     class UniversityAnnouncement : Subject
    {

        private List<Observer> _observers = new List<Observer>();


        public override void Register(Observer observer)
        {
            _observers.Add(observer);
        }

        public override void Remove(Observer observer)
        {
            _observers.Remove(observer);
        }

        public override void Notify(string message)
        {
           foreach(Observer ob in _observers)
            {
                ob.notify(message);
            }
        }


    }
}
