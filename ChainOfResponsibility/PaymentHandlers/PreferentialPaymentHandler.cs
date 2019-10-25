using ChainOfResponsibility.PaymentHandlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class PreferentialPaymentHandler : PaymentHandler
    {
        public override void Handle(Payment payment)
        {
            if(payment.Type == (int)PaymentTypes.Preferential)
            {
                OperationHandler.Execute(payment, "Пільговий", 0);
            }
            else if(Successor != null)
            {
                Successor.Handle(payment);
            }
        }
    }
}
