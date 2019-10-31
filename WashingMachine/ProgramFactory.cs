using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WashingMachine.Programs;

namespace WashingMachine
{
    class ProgramFactory
    {
        private Program cotton;
        private Program synthetic;
        private Program combined;
        public ProgramFactory()
        {
            cotton = new Cotton();
            synthetic = new Synthetics();
            combined = new Combined();
        }

        public Program Create(Type type)
        {
            if (type == typeof(Cotton))
            {
                return cotton;
            }
            else if (type == typeof(Synthetics))
            {
                return synthetic;
            }
            else if(type == typeof(Combined))
            {
                return combined;
            }
            else
            {
                throw new Exception("there is no such program");
            }
        }
    }
}
