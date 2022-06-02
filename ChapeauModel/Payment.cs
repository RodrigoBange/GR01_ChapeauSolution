using System;
using System.Collections.Generic;
using System.Text;

namespace ChapeauModel
{
    public class Payment
    {
        public Bill Bill { get; set; }
        public DateTime TimePaid { get; private set; }
        public PaymentType PaymentType { get; set; }
        public string RestaurantComment { get; set; }
        public double Tip { get; set; }
        public double TotalAmountPaid { get { return Bill.TotalBillPrice + Tip; } }

        public Payment()
        {
            //Set TimePaid to when the Payment object is created
            TimePaid = DateTime.Now;
        }
    }
}
