using System;
using System.Collections.Generic;
using System.Text;

namespace ChapeauModel
{
    public class Payment
    {
        public Bill Bill { get; set; }
        public DateTime TimePaid { get; set; }
        public PaymentType PaymentType { get; set; }
        public string RestaurantComment { get; set; }
    }
}
