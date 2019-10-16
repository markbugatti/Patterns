using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternObserver
{
    class JournalHuman : IObserver
    {
        public void GetParcel()
        {
            MainWindow.mainWindow.ProcessList.Items.Add("ура, я получил свой любимый журнальчик");
        }
    }
}
