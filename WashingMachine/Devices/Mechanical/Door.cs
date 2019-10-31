using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WashingMachine.Devices.Mechanical
{
    public class Door : MechanicalDevice
    {
        public bool IsUnblocked { private set; get; }
        public Door()
        {
            IsUnblocked = true;
        }

        public void Block()
        {
            IsUnblocked = false;
        }
        public void Unblock()
        {
            IsUnblocked = true;
        }
    }
}
