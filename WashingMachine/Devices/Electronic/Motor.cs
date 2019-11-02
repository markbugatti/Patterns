using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WashingMachine.Interfaces;

namespace WashingMachine.Devices.Electronic
{
    public class Motor : ElectronicDevice
    {
        private double rpm;
        public Motor()
        {
            observers = new List<IObserver>();
        }
        public double GetRpm()
        {
            return rpm;
        }

        public override void TurnOn()
        {
            base.TurnOn();
            NotifyObserver("мотор ввідмкнено");
        }

        public override void TurnOff()
        {
            base.TurnOff();
            NotifyObserver("мотор вимкнено");
        }

        public void SetRpm(double value)
        {
            rpm = value;
        }
    }
}
