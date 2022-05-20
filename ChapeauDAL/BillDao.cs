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
        public List<BillItem> GetBillItems(int billID)
        {
            string query = "SELECT m.itemName, COUNT(*) AS [count], M.price, M.tax, M.priceBeforeTax FROM ORDER_ITEMS AS O JOIN [MENU_ITEM] AS M ON O.itemID = M.itemID GROUP BY O.itemID, M.itemName, M.price, M.tax, M.priceBeforeTax";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter();

            return ReadBillItemTables(ExecuteSelectQuery(query, sqlParameters))
        }

        private List<BillItem> ReadBillItemTables(DataTable dataTable)
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
                        VAT = (int)dr["tax"],
                        BasePrice = (float)dr["priceBeforeTax"]
                    };
                    billItems.Add(item);
                }
            }
            catch (Exception ex)
            {
                // Throw exception
                throw new Exception("Something went wrong while reading bill data from the database.");
            }

            // Return list of bill items 
            return billItems;
        }
    }
}
