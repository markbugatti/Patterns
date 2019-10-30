using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.States
{
    class DeferState : IGrantState
    {
        public void Confirm(Grant grant)
        {
            throw new NotImplementedException();
        }

        public void Consider(Grant grant)
        {
            MessageListBoxHandler.OutMessage("грант был отложен, но потом его решили рассмотреть");
            grant.State = new ConsideringState();
        }

        public void Create(Grant grant)
        {
            throw new NotImplementedException();
        }

        public void Defer(Grant grant)
        {
            throw new NotImplementedException();
        }

        public void Refuse(Grant grant)
        {
            throw new NotImplementedException();
        }

        public void Withdraw(Grant grant)
        {
            throw new NotImplementedException();
        }
    }
}
