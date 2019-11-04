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
        public Door door = new Door();
        public Tank tank = new Tank();
        public WaterIntakeValve intakeValve = new WaterIntakeValve();
        public WaterDrainValve drainValve = new WaterDrainValve();
        public Motor motor = new Motor();
        public Thermometer thermometer = new Thermometer();
        public WaterHeater waterHeater = new WaterHeater();
        public MachineTimer machineTimer = new MachineTimer();
        public Container containerA = new ContainerA();
        public Container containerB = new ContainerB();
        public ContainerSmall containerSmall = new ContainerSmall();
        public DetergentSupply detergentSupply = new DetergentSupply();
        public Machine()
        {
            //door = new Door();
            //tank = new Tank();
            //this.program = program;

            //containerA = new ContainerA();
            //containerB = new ContainerB();
            //containerSmall = new ContainerSmall();
            //detergentSupply = new DetergentSupply();
        }

    }
}
