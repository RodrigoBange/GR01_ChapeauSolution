using System;
using System.Collections.Generic;
using System.Text;

namespace ChapeauModel
{
    internal class Payment
    {
        public Bill Bill { get; set; }
        public DateTime TimePaid { get; private set; }
        public PaymentMethod PaymentMethod { get; set; }
        public double Tip { get; set; }
        public double AmountPaid { get; set; }

        public Payment(Bill bill)
        {
            this.Bill = bill;
        }
    }
}
