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
        private Timer timer;
        public MachineTimer()
        {
        }
        /// <summary>
        /// Надо указать сколько секунд будет работать машина
        /// </summary>
        /// <param name="seconds"></param>
        public void Start(int hours, int minutes, int seconds)
        {

            time = new DateTime(
                DateTime.Now.Year,
                DateTime.Now.Month,
                DateTime.Now.Day,
                hours,
                minutes,
                seconds);
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendFormat("таймер запущен на {0}:{1}:{2}", time.Hour, time.Minute, time.Second);
            NotifyObserver(stringBuilder.ToString());
        }

        public void End()
        {
            time = new DateTime(0, 0, 0, 0, 0, 0);
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendFormat("таймер истек {0}:{1}:{2}", time.Hour, time.Minute, time.Second);
            NotifyObserver(stringBuilder.ToString());
        }

        public async Task StartAsync()
        {
            timer.Interval = 1000;
            timer.Elapsed += Timer_Elapsed;
            timer.Start();

            int minute = time.Hour * 60 + time.Minute;
            int second = minute * 60 + time.Second;
            int delay = second * 1000;
            await Task.Delay(delay);
            timer.Stop();
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            time.Subtract(new TimeSpan(0, 0, 1));
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendFormat("Осталось {0}:{1}:{2}", time.Hour, time.Minute, time.Second);
            NotifyObserver(stringBuilder.ToString());
        }
    }
}
