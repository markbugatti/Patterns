using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WashingMachine.Devices.Mechanical.Containers
{
    /// <summary>
    /// порошок засыпают только в том случае, если выбрана программа с предварительной стиркой или замачиванием
    /// </summary>
    class ContainerA : Container
    {
        public ContainerA()
        {
            Name = "Контейнер для попереднього прання";
        }

        public override void Fill()
        {
            base.Fill();
            NotifyObserver("Контейнер для попереднього прання наполнено");
        }

        public override void Empty()
        {
            base.Empty();
            NotifyObserver("Контейнер для попереднього прання порожній");
        }
    }
}
