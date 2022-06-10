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

        private Random rnd;

        //Constructor
        public PaymentService()
        {
            paymentDao = new PaymentDao();
            rnd = new Random();
        }

        //Dictates whether or not Card payment is successfully processed
        public bool SuccessfulPayment()
        {
            int randomNumber = rnd.Next(1, 21);

            return (randomNumber != 1);
        }

        //Insert payment into database
        public void InsertPayment(Payment payment)
        {
            //Insert payment
            paymentDao.InsertPayment(payment);

            //If bill is now paid, mark bill as paid
            if (IsBillPaid(payment.Bill))
            {
                paymentDao.MarkBillAsPaid(payment.Bill.BillId);
            }
        }

        //Insert comment into database
        public void InsertComment(string comment)
        {
            if (IsValidComment(comment))
            {
                paymentDao.InsertComment(comment);
            }
        }

        //Check if comment is valid
        private bool IsValidComment(string comment)
        {
            return (comment != "Ask the guest for a review of their experience and enter here." && !String.IsNullOrEmpty(comment) && comment.Length > 2);
        }

        //Get remaining price on a bill from the database
        public double GetRemainingPrice(Bill bill)
        {
            return (bill.TotalBillPrice - (double)paymentDao.GetPaidAmount(bill));
        }

        //Check if bill is paid
        public bool IsBillPaid(Bill bill)
        {
            return (GetRemainingPrice(bill) <= 0);
        }

        public List<string> CreateFunFactsList()
        {
            List<string> funFacts = new List<string>();

            funFacts.Add("Due to thermal expansion, the Eiffel Tower can grow up to 15 cm taller in the summer.");
            funFacts.Add("A chef's hat has 100 pleats, which is supposed to represent the 100 ways you can cook an egg.");
            funFacts.Add("In France, baguettes can be bought out of vending machines.");
            funFacts.Add("The average French citizen eats 500 snails each year.");
            funFacts.Add("French fries are not actually French. They were invented in America.");
            funFacts.Add("French people usually eat their burgers with cutlery.");
            funFacts.Add("Croissants are not actually French. They were invented by an Austrian.");
            funFacts.Add("The most famous French desert is a cheese plate.");

            return funFacts;
        }
    }
}
