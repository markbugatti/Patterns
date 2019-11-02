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
        public bool IsTurnedOn { protected set; get; }
        public ElectronicDevice()
        {
            IsTurnedOn = false;
        }
        public virtual void TurnOn()
        {
            IsTurnedOn = true;
        }
        public virtual void TurnOff()
        {
            IsTurnedOn = false;
        }
    }
}
