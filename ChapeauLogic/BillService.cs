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

        public BillService()
        {
            billDAO = new BillDao();
        }
        
        public Bill GetBill(int tableNr)
        {
            //Retrieve a bill ID based on the tableNr. If there is no unpaid bill linked to the tablenr, billnr will be returned as 0.
            int billId = billDAO.FindUnpaidBill(tableNr);
            
            //If billId is returned by the above method as 0, this specific error can be thrown.
            if (billId == 0)
            {
                throw new Exception("The selected table does not have an active bill.");
            }

            //If bill ID is valid, a bill object can be created by retrieving a list of bill items.
            Bill bill = new Bill(billId, billDAO.GetBillItems(billId));

            if (bill.BillItems == null)
                throw new Exception("The bill is empty.");
            
            return bill;
        }
    }
}
