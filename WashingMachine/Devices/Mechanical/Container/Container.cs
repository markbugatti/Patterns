using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WashingMachine.Devices.Mechanical.Container
{
    /// <summary>
    /// Контейнер, состоит из трех отделов, но объязательно используеться только MainContainer
    /// </summary>
    class Container : MechanicalDevice
    {
        ContainerA PreWashContainer;
        ContainerB MainContainer;
        ContainerSmall ContainerSmall;
    }
}
