using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ChainOfResponsibility.PaymentHandlers
{
    public class OperationHandler
    {
        public static ListBox listBox { get; set; }
        public static void Execute(Payment payment, string paymentType, decimal percent)
        {
            decimal amount = payment.Amount;
            percent = percent / 100;
            payment.Amount += payment.Amount * percent;
            StringBuilder message = new StringBuilder();
            message.AppendFormat("Платіж №: {0}, \nТип: {4}\nCума переказу: {1}\nВідсотки: {2}\nЗагальна сумма: {3}\n", payment.Id, amount, percent, payment.Amount, paymentType);
            listBox.Items.Add(message.ToString());
        }
    }
}
