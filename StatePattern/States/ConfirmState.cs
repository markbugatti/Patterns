using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.States
{
    class ConfirmState : IGrantState
    {
        public void Confirm(Grant grant)
        {
            throw new NotImplementedException();
        }

        public void Consider(Grant grant)
        {
            throw new NotImplementedException();
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
            MessageListBoxHandler.OutMessage("грант был подтвержден, но потом по некоторым причинам отозван");
            grant.State = new WithdrawState();
        }
    }
}
