using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsPrototype
{
    public class  ConcratePrototype1 : Prototype
    {
        public ConcratePrototype1(string Title, string Text)
            : base(Title, Text)
        { }

        public override Prototype Clone()
        {
            return new ConcratePrototype1(Title, Text);
        }
    }
}
