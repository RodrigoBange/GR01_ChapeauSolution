using System;
using System.Collections.Generic;
using System.Text;
using ChapeauDAL;
using ChapeauModel;

namespace ChapeauLogic
{
    public class BillService
    {
        private BillDao billDAO;
        
        public Bill GetBill(int billId)
        {
            Bill bill = new Bill(billId);
            bill.BillItems = billDAO.GetBillItems(billId);
            return bill;
        }
    }
}
