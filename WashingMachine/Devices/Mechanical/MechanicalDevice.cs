using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WashingMachine.Interfaces;

namespace WashingMachine.Devices.Mechanical
{
    /// <summary>
    /// Представляет механические приборы машини
    /// </summary>
    public class MechanicalDevice : Device
    {
        protected bool isOpen;
        public MechanicalDevice()
        {
            isOpen = false;
        }
        public virtual void Open()
        {
            isOpen = true;
        }
        public virtual void Close()
        {
            isOpen = false;
        }
    }
}
