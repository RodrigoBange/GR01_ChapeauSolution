using System;
using System.Collections.Generic;

namespace ChapeauModel
{
    public class Bill
    {
        public const int NonAlcholicVATPercentage = 6;
        public const int AlcholicVATPercentage = 21;

        public int BillId { get; private set; }
        public List<BillItem> BillItems { get; private set; }
        public double BaseBillPrice { get; private set; }
        public double PriceAlcoholicVAT { get; private set; }
        public double PriceNonAlcoholicVAT { get; private set; }
        public double TotalBillPrice { get { return BaseBillPrice + PriceAlcoholicVAT + PriceNonAlcoholicVAT; } }
        public bool IsPaid { get; set; }

        //Constructor
        public Bill(int billId, List<BillItem> items)
        {
            BillId = billId;
            BillItems = items;
            CalculatePrices();
            IsPaid = false;
        }

        //Calculate Prices (called in constructor)
        public void CalculatePrices()
        {
            BaseBillPrice = 0.00;
            PriceAlcoholicVAT = 0.00;
            PriceNonAlcoholicVAT = 0.00;

            foreach (BillItem item in BillItems)
            {
                if (item.VATPercentage == NonAlcholicVATPercentage)
                {
                    PriceNonAlcoholicVAT += (item.VATPrice * item.Count);
                }
                else
                {
                    PriceAlcoholicVAT += (item.VATPrice * item.Count);
                }
                
                BaseBillPrice += (item.BasePrice * item.Count);
            }
        }
    }
}
