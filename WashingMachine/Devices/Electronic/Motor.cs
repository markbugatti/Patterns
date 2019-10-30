using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WashingMachine.Devices.Electronic
{
    public class Motor : ElectronicDevice
    {
        private decimal rpm;

        public decimal GetRpm()
        {
            return rpm;
        }

        public void SetRpm(decimal value)
        {
            rpm = value;
        }
    }
}
