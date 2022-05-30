using System;
using System.Collections.Generic;
using System.Text;
using ChapeauDAL;
using ChapeauModel

namespace ChapeauLogic
{
    internal class PaymentService
    {
        private PaymentDao paymentDao;

        public PaymentService()
        {
            paymentDao = new PaymentDao();
        }
    }
}
