using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WashingMachine.Devices.Electronic
{
    class WaterHeater : ElectronicDevice
    {
        public void HoldThemperature(Thermometer thermometer, Tank tank)
        {
            NotifyObserver("Вода підігрівається");  
        }
    }
}
