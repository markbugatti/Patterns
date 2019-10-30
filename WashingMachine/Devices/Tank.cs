using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WashingMachine.Devices
{
    class Tank
    {
        decimal maxWeight = 10;
        public decimal Weight
        {
            get
            {
                return Weight;
            }
            set
            {
                if (value <= maxWeight)
                    Weight = value;
            }
        }
    }
}
