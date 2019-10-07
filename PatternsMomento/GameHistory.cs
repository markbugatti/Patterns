using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsMomento
{
    class GameHistory
    {
        public Stack<ButtonMomento> History { get; set; }
        public GameHistory()
        {
            History = new Stack<ButtonMomento>();
        }
    }
}
