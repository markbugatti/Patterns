using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WashingMachine.Devices.Mechanical.Containers
{
    /// <summary>
    /// Главный контейнер, в него объязательно нужно засыпать порошок или другое моющее средство
    /// </summary>
    class ContainerB : Container
    {
        public ContainerB()
        {
            Name = "Головний контейнер";
        }
    }
}
