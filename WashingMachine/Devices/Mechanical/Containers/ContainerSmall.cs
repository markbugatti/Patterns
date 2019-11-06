using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WashingMachine.Devices.Mechanical.Containers
{
    /// <summary>
    /// Маенький контейнер для кондиционера или ополаскивателя белья
    /// </summary>
    class ContainerSmall : Container
    {
        public ContainerSmall()
        {
            Name = "Контейнер для кондеціонеру та ополаскувача";
        }

        public override void Fill()
        {
            base.Fill();
            NotifyObserver("Контейнер для кондиціонеру та ополаскувача наполнено");
        }

        public override void Empty()
        {
            base.Empty();
            NotifyObserver("Контейнер для кондиціонеру та ополаскувача порожній");
        }
    }
}
