using System;
using System.Collections.Generic;
using System.Text;

namespace ChapeauModel
{
    //Object used for displaying products on the bill
    public class BillItem
    {
        public string Name { get; set; }
        public int Count { get; set; }
        public int VATPercentage { get; set; }
        public double VATPrice { get { return (double)(PriceWithVAT - BasePrice); } }
        public double BasePrice { get; set; }
        public double PriceWithVAT { get; set; }
        public double TotalPrice { get { return PriceWithVAT * Count; } }
    }
}
