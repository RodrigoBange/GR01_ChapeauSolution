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
        public float BaseBillPrice { get; private set; }
        public float PriceAlcoholicVAT { get; private set; }
        public float PriceNonAlcoholicVAT { get; private set; }
        public float TotalBillPrice { get { return BaseBillPrice + PriceAlcoholicVAT + PriceNonAlcoholicVAT; } }
        public bool IsPaid { get; set; }

        public Bill(int billId, List<BillItem> items)
        {
            BillId = billId;
            BillItems = items;
            CalculatePrices();
            IsPaid = false;
        }

        public void CalculatePrices()
        {
            BaseBillPrice = 0.00f;
            PriceAlcoholicVAT = 0.00f;
            PriceNonAlcoholicVAT = 0.00f;

            foreach (BillItem item in BillItems)
            {
                if (item.VATPercentage == NonAlcholicVATPercentage)
                {
                    PriceNonAlcoholicVAT += item.VATPrice;
                }
                else
                {
                    PriceAlcoholicVAT += item.VATPrice;
                }
                BaseBillPrice += item.BasePrice;
            }
        }
    }
}
