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
        public ProgramFactory(Machine machine)
        {
            cotton = new Cotton(machine);
            synthetic = new Synthetics(machine);
            combined = new Combined(machine);
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
