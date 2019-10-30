using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.States
{
    class CreatedState : IGrantState
    {
        public void Confirm(Grant grant)
        {
            throw new NotImplementedException();
        }

        public void Consider(Grant grant)
        {
            MessageListBoxHandler.OutMessage("грант создан и передан на рассмотрение");
            grant.State = new ConsideringState();
        }

        public void Create(Grant grant)
        {
        }

        public void Defer(Grant grant)
        {
            MessageListBoxHandler.OutMessage("грант создан и отложен");
            grant.State = new DeferState();
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
