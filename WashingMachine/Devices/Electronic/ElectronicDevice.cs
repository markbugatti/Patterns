using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WashingMachine.Devices
{
    /// <summary>
    /// Представляет электронные приборы машини
    /// </summary>
    public class ElectronicDevice : Device
    {
        private bool isTurnedOn;
        public ElectronicDevice()
        {
            isTurnedOn = false;
        }
        public void TurnOn()
        {
            isTurnedOn = true;
        }
        public void TurnOff()
        {
            isTurnedOn = false;
        }
    }
}
