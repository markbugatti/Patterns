using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using WashingMachine.Devices;

namespace WashingMachine
{
    class Environment
    {
        public void CoolTheWater(Tank tank)
        {
            tank.themperature -= 0.1m;    
        }
    }
}
