using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WashingMachine.Devices.Mechanical
{
    public class Door : MechanicalDevice
    {
        public bool IsUnblocked { private set; get; }
        public Door()
        {
            IsUnblocked = true;
        }
        public override void Open()
        {
            if (IsUnblocked == true)
            {
                base.Open();
                NotifyObserver("Дверцята відкриті");
            }
            else
            {
                NotifyObserver("Двері заблоковані");
            }
        }


        public override void Close()
        {
            base.Close();
            NotifyObserver("Дверцята закриті");
        }
        public void Block()
        {
            IsUnblocked = false;
            NotifyObserver("Дверцята заблаковані");
        }
        public void Unblock()
        {
            IsUnblocked = true;
            NotifyObserver("Дверцята розблаковані");
        }
    }
}
