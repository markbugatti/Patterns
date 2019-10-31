using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using WashingMachine.Interfaces;

namespace WashingMachine.Devices.Dashboard
{
    class Screen : IObserver
    {
        ListBox listBox;
        public Screen(ListBox listBox)
        {
            this.listBox = listBox; 
        }
        public void Update(string message)
        {
            listBox.Items.Add(message);
        }
    }
}
