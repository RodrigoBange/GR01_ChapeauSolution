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
            // Create new list of values
            List<string> values = new List<string>();

            // Get IDs of each orderItem
            foreach (OrderItem item in orderItems)
            {
                string value = $"I.itemID = {item.ItemID} ";
                values.Add(value);
            }

            // Start query
            string query = $@"
                            UPDATE[PRODUCT]
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

            try
            {
                // Edit Database with query
                ExecuteEditQuery(query, sqlParameters);
            }
            catch (Exception ex)
            {
                throw new Exception("There is an issue adjusting the stock in the database.");
            }

        }

        public List<string> CheckStorageStatus(List<OrderItem> orderItems)
        {
            List<string> values = new List<string>();

            // Get IDs of each orderItem
            foreach (OrderItem item in orderItems)
            {
                string value = $"M.itemID = {item.ItemID} ";
                values.Add(value);
            }

            // Start query
            string query = $@"
                            SELECT itemNameShort FROM [MENU_ITEM] AS M
                            JOIN [INGREDIENTS] AS I ON M.itemID = I.itemID
                            JOIN [PRODUCT] AS P ON I.productID = P.productID
                            WHERE (";
                            
            // Add values to query 
            for (int i = 0; i < values.Count; i++)
            {
                if (i < values.Count - 1)
                {
                    query += values[i] + "OR ";
                }
                else
                {
                    query += values[i] + ") ";
                }
            }                 
            
            // End query
            query += $"AND stock < 20;";

            // Set SqlParameter
            SqlParameter[] sqlParameters = new SqlParameter[0];


            try
            {
                // Select from database with query and return list
                return ReadStorageData(ExecuteSelectQuery(query, sqlParameters));
            }
            catch (Exception ex)
            {
                throw new Exception("There is an issue reading the stock status from the database.");
            }
        }

        private List<string> ReadStorageData(DataTable dataTable)
        {
            // Create new list
            List<string> values = new List<string>();

            // If a record has been found
            if (dataTable.Rows.Count > 0)
            {
                // Add all short item names to list
                foreach (DataRow row in dataTable.Rows)
                {
                    values.Add((string)row["itemNameShort"].ToString());
                }
            }
            else
            {
                // If none have been found, return null
                return null;
            }

            // Return the list of names
            return values;
        }
    }
}
