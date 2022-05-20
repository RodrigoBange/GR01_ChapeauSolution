using System;
using System.Collections.Generic;
using System.Text;
using ChapeauDAL;
using ChapeauModel;
using System.Data;
using System.Data.SqlClient;

namespace ChapeauDAL
{
    public class BillDao
    {
        public List<BillItem> GetBillItems(int billID)
        {
            return new List<BillItem>();
        }

        private List<BillItem> ReadTables(DataTable dataTable)
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

            // Return list of menu items 
            return billItems;
        }
    }
}
