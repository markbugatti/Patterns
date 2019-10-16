using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternObserver
{
    class NewspaperHuman : IObserver
    {
        public void GetParcel()
        {
            MainWindow.mainWindow.ProcessList.Items.Add("Ура! я получил свою долгожданную газету");
        }
    }
}
