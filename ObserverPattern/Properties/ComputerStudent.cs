using System;
namespace ObserverPattern.Properties

{
     class ComputerStudent : Observer
    {
        public ComputerStudent()
        {
        }
        public override void notify(string message)
        {
            Console.WriteLine("Hey Computer Student!: " + message);
        }

    }
}
