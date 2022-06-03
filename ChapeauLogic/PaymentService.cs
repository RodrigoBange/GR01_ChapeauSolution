using System;
using System.Collections.Generic;
using System.Text;
using ChapeauDAL;
using ChapeauModel;

namespace ChapeauLogic
{
    public class PaymentService
    {
        private PaymentDao paymentDao;
        private Random rnd = new Random();

        //Constructor
        public PaymentService()
        {
            paymentDao = new PaymentDao();
        }

        //
        public bool SuccessfulPayment()
        {
            int randomNumber = rnd.Next(1, 11);

            return (randomNumber != 1);
        }

        public void InsertPayment(Payment payment)
        {
            paymentDao.InsertPayment(payment);
        }

        public void InsertComment(string comment)
        {

        }
    }
}
