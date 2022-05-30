﻿using ChapeauModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace ChapeauDAL
{
    public class OrderDao : BaseDao
    {
        public void PlaceOrder(List<OrderItem> orderItems, int tableNumber, int employeeID)
        {
            // Lists for query values
            List<string> values = new List<string>();

            // Transfer every order item into a query value
            foreach (OrderItem item in orderItems)
            {
                string value = $"'{item.ItemID}', GETDATE(), '{item.Quantity}', '{item.Comment}'";
                values.Add(value);
            }

            // Start query 
            // If order doesn't exist, create new order and add order items
            string query = $@"
                            DECLARE @orderID AS INT 
                            DECLARE @maxOrderID AS INT 
                            SELECT @orderID = orderID FROM [ORDER] WHERE tableID = '{tableNumber}' AND isPaid = '0' 
                            IF @orderID IS NULL 
                            BEGIN 
                            INSERT INTO [ORDER] (isPaid, tableID, employeeID) 
                            VALUES (0, '{tableNumber}', '{employeeID}') 
                            SELECT @maxOrderID = MAX(orderID) FROM [ORDER] 
                            INSERT INTO [ORDER_ITEMS] (orderID, itemID, orderTime, quantity, comment) 
                            VALUES ";

            // Add values to query
            for (int i = 0; i < values.Count; i++)
            {
                if (i < values.Count - 1)
                {
                    query += $@"(@maxOrderID, " + values[i] + "), ";
                }
                else
                {
                    query += $@"(@maxOrderID, " + values[i] + ") ";
                }
            }

            // Else if order already exists
            query += @"END 
                     ELSE 
                     BEGIN 
                     INSERT INTO [ORDER_ITEMS] (orderID, itemID, orderTime, quantity, comment) 
                     VALUES ";

            // Add values to query
            for (int i = 0; i < values.Count; i++)
            {
                if (i < values.Count - 1)
                {
                    query += $@"(@orderID, " + values[i] + "), ";
                }
                else
                {
                    query += $@"(@orderID, " + values[i] + ") ";
                }
            }

            // End query
            query += "END;";

            // Set SqlParameter
            SqlParameter[] sqlParameters = new SqlParameter[0];

            try
            {
                // Edit Database with query
                ExecuteEditQuery(query, sqlParameters);
            }
            catch (Exception ex)
            {
                throw new Exception("There is an issue placing the order into the database.");
            }
        }

        public bool CheckOrderStatus(int tableNumber)
        {
            // Create query 
            string query = $"SELECT orderID FROM [ORDER] WHERE tableID = {tableNumber} AND isPaid = 0;";

            // Set SqlParameter
            SqlParameter[] sqlParameters = new SqlParameter[0];

            try
            {
                // If a row exists...
                return ReadOrderStatus(ExecuteSelectQuery(query, sqlParameters));
            }
            catch(Exception ex)
            {
                throw new Exception("There is an issue checking for existing and open orders.");
            }
        }

        private bool ReadOrderStatus(DataTable dataTable)
        {
            // If a record has been found return true
            if (dataTable.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                // If none have been found, return false
                return false;
            }
        }
    }
}
