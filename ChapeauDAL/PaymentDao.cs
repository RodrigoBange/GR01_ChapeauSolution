using System;
using System.Collections.Generic;
using ChapeauModel;
using System.Data;
using System.Data.SqlClient;

namespace ChapeauDAL
{
    public class PaymentDao : BaseDao
    {
        //Insert new payment into db table
        public void InsertPayment(Payment payment)
        {
            //Query for inserting new payment
            string query = "INSERT INTO [PAYMENT] VALUES (@BillId, @TimePaid, @PaidAmount, @Tip, @PaymentMethod)";

            SqlParameter[] sqlParameters = new SqlParameter[5];
            sqlParameters[0] = new SqlParameter("@BillId", payment.Bill.BillId);
            sqlParameters[1] = new SqlParameter("@TimePaid", DateTime.Now);
            sqlParameters[2] = new SqlParameter("@PaidAmount", payment.AmountPaid);
            sqlParameters[3] = new SqlParameter("@Tip", payment.Tip);
            sqlParameters[4] = new SqlParameter("@PaymentMethod", (int)payment.PaymentMethod);

            //Insert payment
            ExecuteEditQuery(query, sqlParameters);
        }

        public void InsertComment(string comment)
        {
            string query = "INSERT INTO [RESTAURANTCOMMENT] VALUES (@Comment)";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@Comment", comment);

            try
            {
                ExecuteEditQuery(query, sqlParameters);
            }
            catch (Exception)
            {
                throw new Exception("Something went wrong while inserting the comment into the database.");
            }

        }

        //Update bill to isPaid in db table
        public void MarkBillAsPaid(int billId)
        {
            string query = "UPDATE [ORDER] SET isPaid = 1 WHERE OrderID = @BillId;";

            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@BillId", billId);

            try
            {
                ExecuteEditQuery(query, sqlParameters);
            }
            catch (Exception)
            {
                throw new Exception("Something went wrong while marking the bill as paid in the database.");
            }
        }

        //Retrieves payments made for a bill to calculate remaining price
        public decimal GetPaidAmount(Bill bill)
        {
            string query = "SELECT amountPaid FROM PAYMENT WHERE OrderID = @billId";

            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@BillId", bill.BillId);


            List<decimal> payments = ReadPaymentAmountTable(ExecuteSelectQuery(query, sqlParameters));
            decimal paidAmount = 0;

            //If no payments have been made yet, payments will be returned as null, then 0 must be returned
            if (payments == null)
            {
                return 0;
            }

            foreach (decimal payment in payments)
            {
                paidAmount += payment;
            }

            return paidAmount;

        }

        private List<decimal> ReadPaymentAmountTable(DataTable dataTable)
        {
            List<decimal> payments = new List<decimal>();

            //If no payments have been made yet, datatable will be null
            if (dataTable != null)
            {
                foreach (DataRow dr in dataTable.Rows)
                {
                    decimal payment = (decimal)dr["amountPaid"];
                    payments.Add(payment);
                }

                return payments;
            }
            else
            {
                return null;
            }

        }
    }
