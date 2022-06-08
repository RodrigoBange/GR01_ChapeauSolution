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

        //Dictates whether or not Card payment is successfully processed
        public bool SuccessfulPayment()
        {
            int randomNumber = rnd.Next(1, 21);

            return (randomNumber != 1);
        }

        //Insert payment into db
        public void InsertPayment(Payment payment)
        {
            paymentDao.InsertPayment(payment);
        }

        //Insert comment into db
        public void InsertComment(string comment)
        {
            //paymentDao.InsertComment();
        }
    }
}
