﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WashingMachine.Programs
{
    class Cotton : Program
    {
        public Cotton(Machine machine) : base(machine)
        {
            MaxTemperature = 90;
            MaxDuration = 2;
            SetDuration(0, 0, 15);
            rpm = 1600;
            containers.Add(machine.containerB);
            containers.Add(machine.containerSmall);
        }
    }
}
