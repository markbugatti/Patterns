using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WashingMachine.Interfaces;

namespace WashingMachine.Devices
{
    /// <summary>
    /// Представляет все приборы машини
    /// </summary>
    public abstract class Device: IObservable
    {
        protected List<IObserver> observers = new List<IObserver>();
        protected string message;
        public virtual void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public virtual void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObserver(string message)
        {
            foreach (IObserver observer in observers)
            {
                observer.Update(message);
            }
        }
    }
}
