using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.States
{
    class NoState : IGrantState
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
            MessageListBoxHandler.OutMessage("Грант создан");
            grant.State = new CreatedState();
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
