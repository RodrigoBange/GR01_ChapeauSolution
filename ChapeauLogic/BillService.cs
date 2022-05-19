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
        
        public Bill GetBill()
        {
            return billDAO.GetBill();
        }
    }
}
