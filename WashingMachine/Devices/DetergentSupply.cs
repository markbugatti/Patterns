using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WashingMachine.Devices.Mechanical.Containers;

namespace WashingMachine.Devices.Mechanical
{
    class DetergentSupply : MechanicalDevice
    {
        public void Supply(Container container)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendFormat("подано миючий засіб із контейнеру: {0}", container.Name);
            NotifyObserver(stringBuilder.ToString());        
        }
    }
}
