using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WashingMachine.Programs
{
    class Combined : Program
    {
        public Combined(Machine machine) : base (machine) 
        {
            MaxTemperature = 50;
            MaxDuration = 0.5;
            rpm = 1000;
            containers.Add(machine.containerB);
            containers.Add(machine.containerA);
        }

    }
}
