using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern
{
    internal class Football:Ball
    {
        public Position? position { get; set; }

        private List<IObserver> _observers = new List<IObserver>();

        // The subscription management methods.
        public void Attach(IObserver observer)
        {
            Console.WriteLine("Subject: Attached an observer.");
            this._observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            this._observers.Remove(observer);
            Console.WriteLine("Subject: Detached an observer.");
        }

        public void Notify()
        {
            foreach (IObserver item in this._observers)
            {
                item.Update();
            }
        }

        public void GetBallPosition()
        {
            this.position!.x = new Random().Next(0, 10);
            this.position!.y = new Random().Next(0, 10);
            this.position!.z = new Random().Next(0, 10);

            Console.WriteLine("My state has just changed to: " + position.ToString());
            this.Notify();
        }
    }
}
