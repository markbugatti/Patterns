using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using WashingMachine.Devices.Mechanical;
using WashingMachine.Devices.Mechanical.Containers;

namespace WashingMachine.Programs
{
    abstract class Program
    {
        /// <summary>
        /// Температруа в градусах
        /// </summary>
        protected double temperature;
        /// <summary>
        /// Время в часах. 30 мин. = 0.5
        /// </summary>
        protected DateTime duration;
        protected double MaxTemperature;
        protected double MaxDuration;
        protected double rpm;
        protected Machine machine;
        protected List<Container> containers = new List<Container>();

        public Program(Machine machine)
        {
            this.machine = machine;
        }
        public void SetTemperature(double temperature) 
        {
            if (temperature < MaxTemperature) this.temperature = temperature;
        }
        public double GetTemperature() 
        {  
            return temperature;
        }
        public void SetDuration(int hours, int minutes, int seconds)
        {
            duration = new DateTime(0, 0, 0, hours, minutes, seconds);
        }
        public DateTime GetDuration()
        {
            return duration;
        }
        public async void StartAsync() {
            machine.door.Block();
            machine.intakeValve.Open();
            // запустить таймер на 3 секунды, залить воду
            machine.intakeValve.Close();
            // запустить процес подогрева воды
            machine.waterHeater.KeepThemperature();
            //включить таймер
            machine.machineTimer.Start(duration.Hour, duration.Minute, duration.Second);
            var timerTask = machine.machineTimer.StartAsync();
            machine.motor.TurnOn();
            machine.motor.SetRpm(rpm);
            // можно уменьшить время в таймере для подачи смеси
            foreach(Container container in containers)
            {
                machine.detergentSupply.Supply(container);   
            }

            await timerTask;
            machine.machineTimer.End();
            // злити воду
            machine.drainValve.Open();
            machine.drainValve.Close();
            machine.door.Unblock();
        }
    }
}
