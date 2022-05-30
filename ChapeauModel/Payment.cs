using System;
using System.Collections.Generic;
using System.Text;

namespace ChapeauModel
{
    public class Payment
    {
        public Bill Bill { get; set; }
        public DateTime TimePaid { get; private set; }
        public EnumPaymentType PaymentType { get; set; }
        public string RestaurantComment { get; set; }
        public float Tip { get; set; }
        public float TotalAmountPaid { get { return Bill.TotalBillPrice + Tip; } }

        public Payment()
        {
            //Set TimePaid to when the Payment object is created
            TimePaid = DateTime.Now;
        }
    }
}
