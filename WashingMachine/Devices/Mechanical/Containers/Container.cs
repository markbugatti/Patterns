using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WashingMachine.Devices.Mechanical.Containers
{
    /// <summary>
    /// Контейнер, состоит из трех отделов, но объязательно используеться только MainContainer
    /// </summary>
    public class Container : MechanicalDevice
    {
        public string Name { get; protected set; }
        public bool isFull { get; private set; }
        public Container()
        {
            isFull = false;
        }
        public virtual void Fill()
        {
            isFull = true;
        }
        public virtual void Empty()
        {
            isFull = false;
        }
    } 
}
