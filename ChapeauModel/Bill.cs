﻿using System;
using System.Collections.Generic;

namespace ChapeauModel
{
    public class Bill
    {
        public List<BillItem> BillItems { get; set; }
        public float BaseBillPrice { get; set; }
        public float AlcoholicVAT { get; set; }
        public float NonAlcoholicVAT { get; set; }
        public float TotalBillPrice { get; set; }
        public float Tip { get; set; }
        public float TotalAmountPaid { get; set; }
        public string RestaurantComment { get; set; }
        public bool IsPaid { get; set; }
    }
}