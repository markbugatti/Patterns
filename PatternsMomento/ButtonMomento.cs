using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsMomento
{
    class ButtonMomento
    {
        public string Content { get; private set; }
        public string Name { get; private set; }
        public ButtonMomento(string name, string content)
        {
            Name = name;
            Content = content;
        }
    }
}
