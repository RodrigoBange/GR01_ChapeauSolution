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
                                FROM [PRODUCT] AS P 
                                INNER JOIN [INGREDIENTS] AS I 
                                ON P.productID = I.productID 
                                WHERE I.itemID = @itemID";

                // Set SqlParameter
                SqlParameter[] sqlParameters =
                {
                    new SqlParameter("@itemID", item.ItemID)
                };

                try
                {
                    // Deplete item stock in database
                    ExecuteEditQuery(query, sqlParameters);
                }
                catch (Exception ex)
                {
                    throw new Exception("There is an issue adjusting the stock in the database.");
                }
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
                                JOIN [INGREDIENTS] AS I ON M.itemID = I.itemID
                                JOIN [PRODUCT] AS P ON I.productID = P.productID
                                WHERE M.itemID = @itemID AND stock < 20;";

                // Set parameters
                SqlParameter[] sqlParameters =
                {
                    new SqlParameter("@itemID", orderItem.ItemID)
                };

                try
                {
                    // Select from database with query and add to list
                    string itemName = ReadStorageData(ExecuteSelectQuery(query, sqlParameters));
                    if (itemName != null) { lowStockItems.Add(itemName); }
                }
                catch (Exception ex)
                {
                    throw new Exception("There is an issue reading the stock status from the database.");
                }
            }

            // Return list
            if (lowStockItems.Count > 0) { return lowStockItems; }
            else { return null; }
        }

        private string ReadStorageData(DataTable dataTable)
        {
            // If a record has been found
            if (dataTable.Rows.Count > 0)
            {
                // Return item name
                return dataTable.Rows[0]["itemNameShort"].ToString();
            }
            else
            {
                // If none have been found, return null
                return null;
            }
        }
    }
}
