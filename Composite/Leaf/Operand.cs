using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Leaf
{
    public class Operand : Component
    {
        public override void Add(Component component)
        {
            throw new NotImplementedException();
        }

        public override void Add(int value)
        {
            Value = value;
        }

        public override void Display()
        {
            throw new NotImplementedException();
        }

        public override double Execute()
        {
            throw new NotImplementedException();
        }

        public override void Remove(Component component)
        {
            throw new NotImplementedException();
        }
    }
}
