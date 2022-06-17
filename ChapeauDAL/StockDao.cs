using ChapeauModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace ChapeauDAL
{
    public class StockDao : BaseDao
    {
        public void DepleteStock(List<OrderItem> orderItems)
        {
            foreach (OrderItem item in orderItems)
            {
                // Create query
                string query = @"UPDATE [PRODUCT] 
                                SET stock = stock - I.quantity 
                                FROM [PRODUCT] AS P INNER JOIN [INGREDIENT] AS I 
                                ON P.productID = I.productID 
                                WHERE I.itemID = @itemID";

                // Set SqlParameter
                SqlParameter[] sqlParameters =
                {
                    new SqlParameter("@itemID", item.ItemID)
                };

                // Deplete item stock in database
                ExecuteEditQuery(query, sqlParameters);
            }
        }

        public List<string> CheckStorageStatus(List<OrderItem> orderItems)
        {
            // Create new list of low stock item names
            List<string> lowStockItems = new List<string>();

            foreach (OrderItem orderItem in orderItems)
            {
                // Create query
                string query = $@"SELECT itemNameShort FROM [MENU_ITEM] AS M
                                JOIN [INGREDIENT] AS I ON M.itemID = I.itemID
                                JOIN [PRODUCT] AS P ON I.productID = P.productID
                                WHERE M.itemID = @itemID AND stock < 20;";

                // Set parameters
                SqlParameter[] sqlParameters =
                {
                    new SqlParameter("@itemID", orderItem.ItemID)
                };

                // Select from database with query and add to list
                string itemName = ReadStorageData(ExecuteSelectQuery(query, sqlParameters));
                if (itemName != null) { lowStockItems.Add(itemName); }
            }

            // Return list
            if (lowStockItems.Count > 0) { return lowStockItems; }
            else { return null; }
        }

        private string ReadStorageData(DataTable dataTable)
        {
            // If a record has been found
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                // Return item name
                return dataTable.Rows[0]["itemNameShort"].ToString();
            }
            else
            {
                // If a record hasn't been found
                return null;
            }
        }
    }
}
