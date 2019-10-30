using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Composite.Leaf;

namespace Composite.Composite
{
    public class MinusCompsite : Composite
    {
        public override void Add(int value)
        {
            throw new NotImplementedException();
        }

        public override void Display()
        {
            throw new NotImplementedException();
        }

        public override double Execute()
        {
            Value = children[1].Value - children[0].Value;
            children.Clear();
            return Value;
        }
    }
}
