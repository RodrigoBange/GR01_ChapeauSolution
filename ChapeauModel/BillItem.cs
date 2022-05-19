using System;
using System.Collections.Generic;
using System.Text;

namespace ChapeauModel
{
    public class BillItem
    {
        public string Name { get; set; }
        public int Count { get; set; }
        public float VAT { get; set; }
        public float BasePrice { get; set; }
        public float PriceWithVAT { get { return (BasePrice * (float)(1 + VAT)); } }
        public float TotalPrice { get { return (float)((BasePrice * (float)(1 + VAT)) * Count); } }
    }
}
