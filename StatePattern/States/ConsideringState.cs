using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.States
{
    class ConsideringState : IGrantState
    {
        public void Confirm(Grant grant)
        {
            MessageListBoxHandler.OutMessage("грант рассмотрен и подтвержден");
            grant.State = new ConfirmState();
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
            MessageListBoxHandler.OutMessage("грант рассмотрен и отложен");
            grant.State = new DeferState();
        }

        public void Refuse(Grant grant)
        {
            MessageListBoxHandler.OutMessage("грант рассмотрен и отклонен");
            grant.State = new RefuseState();
        }

        public void Withdraw(Grant grant)
        {
            throw new NotImplementedException();
        }
    }
}
