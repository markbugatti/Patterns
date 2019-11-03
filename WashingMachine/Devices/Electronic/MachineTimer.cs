using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace WashingMachine.Devices.Electronic
{
    class MachineTimer : ElectronicDevice
    {
        private DateTime time;
        public MachineTimer()
        {
        }
        /// <summary>
        /// Надо указать сколько секунд будет работать машина
        /// </summary>
        /// <param name="seconds"></param>
        public void Start(int hours, int minutes)
        {

            time = new DateTime(
                DateTime.Now.Year,
                DateTime.Now.Month,
                DateTime.Now.Day,
                hours,
                minutes,
                0);
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendFormat("таймер запущен на {0}:{1}:{2}", time.Hour, time.Minute, time.Second);
            NotifyObserver(stringBuilder.ToString());
        }
    }
}
