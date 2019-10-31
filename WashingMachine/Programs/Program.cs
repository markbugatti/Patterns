using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

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
        protected double duration;
        protected double MaxTemperature;
        protected double MaxDuration;
        protected double rpm;
        private double passedTime;
        private double interval;
        Timer MachineTimer;
        protected Machine machine;

        public Program(Machine machine)
        {
            this.machine = machine;
            passedTime = 0;
            interval = 1000;
        }
        public void SetTemperature(double temperature) 
        {
            if (temperature < MaxTemperature) this.temperature = temperature;
        }
        public double GetTemperature() 
        {  
            return temperature;
        }
        public void SetDuration(double duration) 
        {
            if (duration < MaxDuration) this.duration = duration;
        }
        public double GetDuration()
        {
            return duration;
        }
        public void Start() {
            if (!machine.door.IsUnblocked)
            {
                machine.door.Block();
                machine.intakeValve.Open();
                // запустить таймер на 3 секунды, залить воду
                machine.intakeValve.Close();
                // запустить процес подогрева воды
                //включить таймер
                MachineTimer.Interval = interval;
                MachineTimer.Elapsed += MachineTimer_Elapsed;
                MachineTimer.Start();

                machine.motor.TurnOn();
                machine.motor.SetRpm(rpm);


                // злити воду
                machine.drainValve.Open();
                // запустить таймер на 3 секунды, вылить воду
                machine.drainValve.Close();
            }
            else
            {
                // вывести на монитор закройте дверь, запустите снова
            }

        }

        private void MachineTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            passedTime += interval;
            if(passedTime >= duration)
            {
                machine.motor.TurnOff();
            }    
        }
    }
}
