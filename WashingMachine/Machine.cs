using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using WashingMachine.Devices;
using WashingMachine.Devices.Dashboard;
using WashingMachine.Devices.Electronic;
using WashingMachine.Devices.Mechanical;
using WashingMachine.Devices.Mechanical.Containers;
using WashingMachine.Programs;

namespace WashingMachine
{
    class Machine
    {
        public Door door;
        public Tank tank;
        Container container;
        Dashboard dashboard;
        Program program;
        public WaterIntakeValve intakeValve;
        public WaterDrainValve drainValve;
        public Motor motor;
        public Thermometer thermometer;
        public WaterHeater waterHeater;
        public MachineTimer machineTimer;
        public Container containerA;
        public Container containerB;
        public ContainerSmall containerSmall;
        public DetergentSupply detergentSupply;
        public Machine()
        {
            containerA = new ContainerA();
            containerB = new ContainerB();
            containerSmall = new ContainerSmall();
            detergentSupply = new DetergentSupply();
        }

    }
}
