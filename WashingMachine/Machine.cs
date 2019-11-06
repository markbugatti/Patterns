using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Controls;
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
        public Screen programScreen;
        public Screen systemScreen;
        public Machine(ListBox ProgramScreen, ListBox systemScreen)
        {
            this.programScreen = new Screen(ProgramScreen);
            this.systemScreen = new Screen(systemScreen);
            door.RegisterObserver(this.programScreen);
            tank.RegisterObserver(this.programScreen);
            intakeValve.RegisterObserver(this.programScreen);
            drainValve.RegisterObserver(this.programScreen);
            motor.RegisterObserver(this.programScreen);
            thermometer.RegisterObserver(this.programScreen);
            waterHeater.RegisterObserver(this.programScreen);
            machineTimer.RegisterObserver(this.programScreen);
            detergentSupply.RegisterObserver(this.programScreen);
            
            containerA.RegisterObserver(this.systemScreen);
            containerB.RegisterObserver(this.systemScreen);
            containerSmall.RegisterObserver(this.systemScreen);
        }
    }
}
