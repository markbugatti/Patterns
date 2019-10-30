using StatePattern.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    class Grant
    {
        public IGrantState State { get; set; }
        public Grant()
        {
            State = new NoState();
        }
        public void Create()
        {
            State.Create(this);
        }
        public void Consider()
        {
            State.Consider(this);
        }
        public void Confirm()
        {
            State.Confirm(this);
        }
        public void Defer()
        {
            State.Defer(this);
        }
        public void Refure()
        {
            State.Refuse(this);
        }
        public void Withdraw()
        {
            State.Withdraw(this);
        }
    }
}
