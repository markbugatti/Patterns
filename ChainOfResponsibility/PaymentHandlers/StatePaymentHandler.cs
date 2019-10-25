using ChainOfResponsibility.PaymentHandlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class StatePaymentHandler : PaymentHandler
    {
        public override void Handle(Payment payment)
        {
            if (payment.Type == (int)PaymentTypes.State)
            {
                OperationHandler.Execute(payment, "державний", 5.2m);
            }
            else if (Successor != null)
            {
                Successor.Handle(payment);
            }
        }
    }
}
