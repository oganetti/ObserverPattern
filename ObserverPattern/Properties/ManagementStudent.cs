using System;
namespace ObserverPattern.Properties
{
     class ManagementStudent : Observer
    {
        public override void notify(string message)
        {
            Console.WriteLine("Hey Management Student!: " + message);
        }
    }
}
