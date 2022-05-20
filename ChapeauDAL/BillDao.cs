using System;
using System.Collections.Generic;
using System.Text;
using ChapeauDAL;
using ChapeauModel;
using System.Data;
using System.Data.SqlClient;

namespace ChapeauDAL
{
    public class BillDao : BaseDao
    {
        string query;
        public List<BillItem> GetBillItems(int billId) //Gets all items linked to a bill
        {
            query = "SELECT m.itemName, COUNT(*) AS [count], M.price, M.tax, M.priceBeforeTax "
                + "FROM ORDER_ITEMS AS O JOIN [MENU_ITEM] AS M ON O.itemID = M.itemID "
                + "WHERE O.orderID = @billId "
                + "GROUP BY O.itemID, M.itemName, M.price, M.tax, M.priceBeforeTax;";

            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@billId", billId);

            return ReadBillItemTable(ExecuteSelectQuery(query, sqlParameters));
        }


        public int FindUnpaidBill(int tableNr) //Checks if a table has an unpaid bill, and if so, returns it
        {
            query = "SELECT orderID "
                    + "FROM[ORDER] "
                    + "WHERE tableID = @tableNr AND isPaid = 0;";

            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@tableNr", tableNr);
            
            int billId = ReadBillIDTable(ExecuteSelectQuery(query, sqlParameters));

            return billId;
        }

        public void InsertPayment(Bill bill)
        {

        }

        private List<BillItem> ReadBillItemTable(DataTable dataTable)
        {
            // Create new list of Bill items
            List<BillItem> billItems = new List<BillItem>();

            try
            {
                // Fill list of Bill items
                foreach (DataRow dr in dataTable.Rows)
                {
                    BillItem item = new BillItem()
                    {
                        Name = (string)dr["itemName"],
                        Count = (int)dr["count"],
                        PriceWithVAT = (float)dr["price"],
                        VATPercentage = (int)dr["tax"],
                        BasePrice = (float)dr["priceBeforeTax"]
                    };
                    billItems.Add(item);
                }
                // Return list of bill items
                return billItems;
            }
            catch (Exception ex)
            {
                // Throw exception
                throw new Exception("Something went wrong while reading bill data from the database.");
            }
        }

        private int ReadBillIDTable(DataTable dataTable)
        {
            try
            {
                //Retrieve billID
                int billId;

                DataRow dr = dataTable.Rows[0];
                if (!dr.IsNull("orderID"))
                {
                    billId = (int)dr["orderID"];
                }
                else
                {
                    billId = 0;
                }

                return billId;
            }
            catch (Exception ex)
            {
                // Throw exception
                throw new Exception("Something went wrong while reading bill data from the database.");
            }
        }
    }
}
