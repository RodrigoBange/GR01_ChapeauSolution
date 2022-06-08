using System;
using System.Collections.Generic;
using System.Text;

namespace ChapeauModel
{
    public class Payment
    {
        public Bill Bill { get; set; }
        public DateTime TimePaid { get; private set; }
        public PaymentMethod PaymentMethod { get; set; }
        public string RestaurantComment { get; set; }
        public double Tip { get; set; }
        public double TotalAmountPaid { get; set; }

        public Payment()
        {
           
        }
    }
}
