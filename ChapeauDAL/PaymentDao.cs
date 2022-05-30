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
        public void InsertPayment(Payment payment) //Insert new payment into db table
        {
            //Query for inserting new payment
            string query = "INSERT INTO PAYMENT VALUES (@BillId, @TimePaid, @Tip, @TotalPrice, @PaidAmount, @PaymentType, @Comment)";

            SqlParameter[] sqlParameters = new SqlParameter[7];
            sqlParameters[0] = new SqlParameter("@BillId", payment.Bill.BillId);
            sqlParameters[1] = new SqlParameter("@TimePaid", payment.TimePaid);
            sqlParameters[2] = new SqlParameter("@Tip", payment.Tip);
            sqlParameters[3] = new SqlParameter("@TotalPrice", payment.Bill.TotalBillPrice);
            sqlParameters[4] = new SqlParameter("@PaidAmount", payment.TotalAmountPaid);
            sqlParameters[5] = new SqlParameter("@PaymentType", (int)payment.PaymentType);
            sqlParameters[6] = new SqlParameter("@Comment", payment.RestaurantComment);

            //Insert payment and call method to mark the bill as paid in the bills table
            ExecuteEditQuery(query, sqlParameters);
            MarkBillAsPaid(payment.Bill.BillId);
        }
        
        private void MarkBillAsPaid(int billId) //Update bill to isPaid in db table
        {
            string query = "UPDATE [ORDER] SET isPaid = 1 WHERE OrderID = @BillId;";
            
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@BillId", billId);

            ExecuteEditQuery(query, sqlParameters);
        }
    }
}
