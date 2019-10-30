using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public abstract class Component
    {
        public double Value { get; set; }
        public abstract void Display();
        public abstract void Add(Component component);
        public abstract void Add(int value);
        public abstract void Remove(Component component);
        public abstract double Execute();
    }
}
