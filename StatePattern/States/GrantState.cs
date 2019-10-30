using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.States
{
    interface IGrantState
    {
        void Create(Grant grant);
        void Confirm(Grant grant);
        void Consider(Grant grant);
        void Defer(Grant grant);
        void Refuse(Grant grant);
        void Withdraw(Grant grant);
    }
}
