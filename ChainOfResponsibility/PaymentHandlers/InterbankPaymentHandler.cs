using ChainOfResponsibility.PaymentHandlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class InterbankPaymentHandler : PaymentHandler
    {
        public override void Handle(Payment payment)
        {
            OperationHandler.Execute(payment, "внутрішній", 0);
        }
    }
}
