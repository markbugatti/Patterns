using ChainOfResponsibility.PaymentHandlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class RegularPaymentHandler : PaymentHandler
    {
        public override void Handle(Payment payment)
        {
            if (payment.Type == (int)PaymentTypes.Regular)
            {
                OperationHandler.Execute(payment, "Звичайний", 2.2m);
            }
            else if (Successor != null)
            {
                Successor.Handle(payment);
            }
        }
    }
}
