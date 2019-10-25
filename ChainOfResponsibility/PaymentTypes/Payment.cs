using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class Payment
    {
        public Guid Id { get; private set; }
        public int Type { get; private set; }
        public decimal Amount { get; set; }
        public Payment(Guid id, int type, decimal amount)
        {
            Id = id;
            Type = type;
            Amount = amount;
        }
    }
}
