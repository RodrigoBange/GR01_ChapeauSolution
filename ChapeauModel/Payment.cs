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

        //When Payment object is made, set the time of payment to now.
        public Payment()
        {
            TimePaid = DateTime.Now;
        }
    }
}
