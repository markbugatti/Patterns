using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WashingMachine.Programs
{
    abstract class Program
    {
        /// <summary>
        /// Температруа в градусах
        /// </summary>
        protected decimal temperature;
        /// <summary>
        /// Время в часах. 30 мин. = 0.5
        /// </summary>
        protected decimal duration;
        protected decimal MaxTemperature;
        protected decimal MaxDuration;
        public void SetTemperature(decimal temperature) 
        {
            if (temperature < MaxTemperature) this.temperature = temperature;
        }
        public decimal GetTemperature() 
        {  
            return temperature;
        }
        public void SetDuration(decimal duration) 
        {
            if (duration < MaxDuration) this.duration = duration;
        }
        public decimal GetDuration()
        {
            return duration;
        }
        public void Start(Machine machine) {
            if(!machine.door.IsUnblocked)
                machine.door.Block();
            else
            {
                // вывести на монитор закройте дверь, запустите снова
            }
        }
    }
}
