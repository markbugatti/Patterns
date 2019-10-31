using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WashingMachine.Interfaces;

namespace WashingMachine.Devices.Electronic
{
    public class Motor : ElectronicDevice, IObservable
    {
        private double rpm;
        private List<IObserver> observers;
        public double GetRpm()
        {
            return rpm;
        }

        public void NotifyObserver()
        {
            foreach(IObserver observer in observers)
            {
                string message;
                if(IsTurnedOn)
                {
                    message = "мотор ввідмкнений";
                }
                else
                {
                    message = "мотор вимкнений";
                }
                observer.Update(message);
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void SetRpm(double value)
        {
            rpm = value;
        }
    }
}
