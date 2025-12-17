using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGTraining
{
    public class PaymentService
    {
        public bool ProcessPayment(Payment payment)
        {
            return payment.Amount > 0;
        }

    }

    public class Payment
    {
        public double Amount { get; set; }
    }
}
