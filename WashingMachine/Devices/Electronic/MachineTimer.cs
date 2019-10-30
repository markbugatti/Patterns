using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace WashingMachine.Devices.Electronic
{
    class MachineTimer : ElectronicDevice
    {
        private Timer timer;

        public Timer GetTimer()
        {
            return timer;
        }

        public void SetTimer(Timer value)
        {
            timer = value;
        }
    }
}
