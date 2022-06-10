using System;
using System.Collections.Generic;
using System.Text;

namespace ChapeauModel
{
    public class BillItem
    {
        public string Name { get; set; }
        public int Count { get; set; }
        public int VAT { get; set; }
        public float BasePrice { get; set; }
        public float PriceWithVAT { get; set; }
        public float TotalPrice { get { return PriceWithVAT * Count; } }
    }
}
