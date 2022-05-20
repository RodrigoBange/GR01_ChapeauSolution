using System;
using System.Collections.Generic;

namespace ChapeauModel
{
    public class Bill
    {
        public int BillId { get; set; }
        public List<BillItem> BillItems { get; set; }
        public float BaseBillPrice { get; set; }
        public float AlcoholicVAT { get; set; }
        public float NonAlcoholicVAT { get; set; }
        public float TotalBillPrice { get { return BaseBillPrice + AlcoholicVAT + NonAlcoholicVAT; } }
        public float Tip { get; set; }
        public float TotalAmountPaid { get { return TotalBillPrice + Tip; } }
        public string RestaurantComment { get; set; }
        public bool IsPaid { get; set; }

        public Bill(int billId)
        {
            BillId = billId;
            BillItems = new List<BillItem>();
        }
    }
}
