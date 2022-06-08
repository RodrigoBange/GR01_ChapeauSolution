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
        //Gets all items linked to a bill from dbo.ORDER, formats it to class BillItem
        public List<BillItem> GetBillItems(int billId) 
        {
            string query = "SELECT m.itemNameShort, COUNT(*) AS [count], M.price, M.tax, M.priceBeforeTax FROM ORDER_ITEMS AS O JOIN [MENU_ITEM] AS M ON O.itemID = M.itemID GROUP BY O.orderID, O.itemID, M.itemNameShort, M.price, M.tax, M.priceBeforeTax HAVING O.orderID = @billId;";

            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@billId", billId);

            return ReadBillItemTable(ExecuteSelectQuery(query, sqlParameters));
        }

        //Checks if a table has an unpaid bill, and if so, returns it. Otherwise, returns 0
        //(Can also be used by Table View to identify active tables)
        public int FindUnpaidBill(int tableNr) 
        {
            string query = "SELECT orderID "
                    + "FROM [ORDER] "
                    + "WHERE tableID = @tableNr AND isPaid = 0;";

            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@tableNr", tableNr);
            
            //This method returns billId if an unpaid bill is found, otherwise it returns 0
            int billId = ReadBillIDTable(ExecuteSelectQuery(query, sqlParameters));

            return billId;
        }

        

        //Reads BillItems from Database and returns it to the bill
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
                        Name = (string)dr["itemNameShort"],
                        Count = (int)dr["count"],
                        PriceWithVAT = (double)(decimal)dr["price"],
                        VATPercentage = (int)(decimal)dr["tax"],
                        BasePrice = (double)(decimal)dr["priceBeforeTax"]
                    };
                    billItems.Add(item);
                }
                // Return list of bill items
                return billItems;
            }
            catch (Exception)
            {
                // Throw exception
                throw new Exception("Something went wrong while reading bill data from the database.");
            }
        }

        //Tries to find an unpaid bill, using a table nr
        private int ReadBillIDTable(DataTable dataTable)
        {
            try
            {
                //Retrieve billID
                int billId;

                DataRow dr = dataTable.Rows[0];

                //If datarow is empty, return billId = 0
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
            catch (Exception)
            {
                // Throw exception
                throw new Exception("Something went wrong while reading bill data from the database.");
            }
        }

        
    }
}
