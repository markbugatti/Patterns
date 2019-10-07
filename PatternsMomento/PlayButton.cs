using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsMomento
{
    class PlayButton : System.Windows.Controls.Button
    {
        public void RestoreState(ButtonMomento buttonMomento)
        {
            Content = buttonMomento.Content;
        }
        public ButtonMomento SaveState()
        {
            return new ButtonMomento(Name, Content.ToString());
        }
    }
}
