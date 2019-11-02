using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WashingMachine.Interfaces;

namespace WashingMachine.Devices.Mechanical
{
    public class WaterDrainValve : MechanicalDevice
    {
        public override void Open()
        {
            base.Open();
            NotifyObserver("Зливний клапан відкрито");
        }

        public override void Close()
        {
            base.Close();
            NotifyObserver("Зливний клапан закритий");
        }
    }
}
