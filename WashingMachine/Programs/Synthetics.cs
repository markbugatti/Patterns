using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WashingMachine.Programs
{
    class Synthetics : Program
    {
        public Synthetics(Machine machine) : base(machine)
        {
            MaxTemperature = 40;
            MaxDuration = 1.5;
            rpm = 1400;
            containers.Add(machine.containerB);
            containers.Add(machine.containerSmall);
        }
    }
}
