using System;
using System.Collections.Generic;

namespace ChapeauModel
{
    //Collective list of items registered to a bill, with calculated collective properties
    public class Bill
    {
        public const int NonAlcholicVATPercentage = 6;
        public const int AlcholicVATPercentage = 21;

        public int BillId { get; private set; }
        public List<BillItem> BillItems { get; private set; }
        
        public double PriceExclVATAlcoholic { get; private set; }
        public double VATAlcoholic { get; private set; }
        public double PriceInclVATAlcoholic { get { return (PriceExclVATAlcoholic + VATAlcoholic); } }
        
        public double PriceExclVATNonAlcoholic { get; private set; }
        public double VATNonAlcoholic { get; private set; }
        public double PriceInclVATNonAlcoholic { get { return (PriceExclVATNonAlcoholic + VATNonAlcoholic); } }

        public double TotalBillPrice { get { return (PriceInclVATNonAlcoholic + PriceInclVATAlcoholic); } }
        public double PriceRemaining { get; set; }
        public bool IsPaid { get { return (PriceRemaining <= 0); } }

        //Constructor
        public Bill(int billId, List<BillItem> items)
        {
            BillId = billId;
            BillItems = items;
            CalculatePrices();
        }

        //Calculate Prices (called in constructor)
        public void CalculatePrices()
        {
            PriceExclVATAlcoholic = 0.00;
            PriceExclVATNonAlcoholic = 0.00;
            VATAlcoholic = 0.00;
            VATNonAlcoholic = 0.00;

            foreach (BillItem item in BillItems)
            {
                if (item.VATPercentage == NonAlcholicVATPercentage)
                {
                    PriceExclVATNonAlcoholic += (item.BasePrice * item.Count);
                    VATNonAlcoholic += (item.VATPrice * item.Count);
                }
                else
                {
                    PriceExclVATAlcoholic += (item.BasePrice * item.Count);
                    VATAlcoholic += (item.VATPrice * item.Count);
                }
            }
        }
    }
}
