using System;
using System.Collections.Generic;
using System.Text;
using ChapeauDAL;
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
            string query = "INSERT INTO PAYMENT VALUES (@BillId, @TimePaid, @Tip, @TotalPrice, @PaidAmount, @PaymentMethod, @Comment)";

            SqlParameter[] sqlParameters = new SqlParameter[7];
            sqlParameters[0] = new SqlParameter("@BillId", payment.Bill.BillId);
            sqlParameters[1] = new SqlParameter("@TimePaid", DateTime.Now);
            sqlParameters[2] = new SqlParameter("@Tip", payment.Tip);
            sqlParameters[3] = new SqlParameter("@TotalPrice", payment.Bill.TotalBillPrice);
            sqlParameters[4] = new SqlParameter("@PaidAmount", payment.TotalAmountPaid);
            sqlParameters[5] = new SqlParameter("@PaymentMethod", (int)payment.PaymentMethod);
            sqlParameters[6] = new SqlParameter("@Comment", payment.RestaurantComment);

            //Insert payment and call method to mark the bill as paid in the bills table
            ExecuteEditQuery(query, sqlParameters);
        }

        private void InsertComment()
        {
            //string query = ""
        }

        //Update bill to isPaid in db table
        private void MarkBillAsPaid(int billId) 
        {
            string query = "UPDATE [ORDER] SET isPaid = 1 WHERE OrderID = @BillId;";
            
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@BillId", billId);

            ExecuteEditQuery(query, sqlParameters);
        }
        
        //Retrieves payments made for a bill to calculate remaining price
        public decimal GetPaidAmount(Bill bill)
        {
            string query = "SELECT totalAmountPaid FROM PAYMENT WHERE OrderID = @billId";
            
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@BillId", bill.BillId);

            try
            {
                List<decimal> payments = ReadPaymentAmountTable(ExecuteSelectQuery(query, sqlParameters));
                decimal paidAmount = 0;

                foreach (decimal payment in payments)
                {
                    paidAmount += payment;
                }

                return paidAmount;
            }
            catch (Exception)
            {
                throw new Exception("Something went wrong while collecting payment data.");
            }
        }

        private List<decimal> ReadPaymentAmountTable(DataTable dataTable)
        {
            try
            {
                List<decimal> payments = new List<decimal>();
                foreach (DataRow dr in dataTable.Rows)
                {
                    decimal payment = (decimal)dr["totalAmountPaid"];
                    payments.Add(payment);
                }

                return payments;
            }
            catch (Exception)
            {

                throw new Exception("Something went wrong while collecting payment data.");
            }
            
        }
    }
}
