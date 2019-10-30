using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WashingMachine.Devices.Electronic
{
    class Thermometer : ElectronicDevice
    {
        private decimal temperature;

        public decimal GetTemperature()
        {
            return temperature;
        }

        public void SetTemperature(decimal value)
        {
            temperature = value;
        }

        public decimal Measure()
        {
            return GetTemperature();
        }
    }
}
