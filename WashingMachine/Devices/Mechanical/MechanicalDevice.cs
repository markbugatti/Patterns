using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public void Open()
        {
            isOpen = true;
        }
        public void Close()
        {
            isOpen = false;
        }
    }
}
