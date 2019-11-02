using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WashingMachine.Devices.Mechanical
{
    public class WaterIntakeValve : MechanicalDevice
    {
        public override void Open()
        {
            base.Open();
            NotifyObserver("Клапан забору води відкрито");
        }

        public override void Close()
        {
            base.Close();
            NotifyObserver("Клапан забору води закрито");
        }
    }
}
