using ChapeauModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace ChapeauDAL
{
    public class StockDao : BaseDao
    {
        public void DepleteStock(List<OrderItem> orderItems)
        {
            // Create new list of values
            List<string> values = new List<string>();

            // Get IDs of each orderItem
            foreach (OrderItem item in orderItems)
            {
                string value = $"I.itemID = {item.ItemID} ";
                values.Add(value);
            }

            // Start query
            string query = $@"UPDATE[PRODUCT]
                            SET stock = stock - I.quantity
                            FROM [PRODUCT] AS P
                            INNER JOIN [INGREDIENTS] AS I
                            ON P.productID = I.productID
                            WHERE ";
                            
            // Add values to update to query
            for (int i = 0; i < values.Count; i++)
            {
                if (i < values.Count - 1)
                {
                    query += values[i] + "OR ";
                }
                else
                {
                    query += values[i] + ";";
                }
            }
            // End query 

            // Set SqlParameter
            SqlParameter[] sqlParameters = new SqlParameter[0];

            // Edit Database with query
            ExecuteEditQuery(query, sqlParameters);
        }
    }
}
