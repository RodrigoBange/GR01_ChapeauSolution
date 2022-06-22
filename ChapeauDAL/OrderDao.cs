using ChapeauModel;
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
            // Get the orderID from the database for an open order (Returns 0 if none exist)
            int orderID = GetOrderID(tableNumber);

            // If an orderID exists...
            if (orderID != 0)
            {
                // Add new order items to existing order
                AddNewOrder(orderItems, orderID);
            }
            else
            {
                // Create a new order in the database
                CreateNewOrder(tableNumber, employeeID);

                // Get the orderID of the new table order from the database
                orderID = GetOrderID(tableNumber);

                // Add order items to the new order
                AddNewOrder(orderItems, orderID);
            }
        }

        /* CREATING NEW ORDER METHODS */
        private void AddNewOrder(List<OrderItem> orderItems, int orderID)
        {
            try
            {
                // Get the current time of order placement
                DateTime orderTime = DateTime.Now;

                foreach (OrderItem item in orderItems)
                {
                    // Create query
                    string query = @"INSERT INTO [ORDER_ITEM] (orderID, itemID, orderTime, comment, quantity) 
                                    VALUES (@orderID, @itemID, @dateTime, @comment, @quantity)";

                    // Set parameters for new order
                    SqlParameter[] sqlParametersAddToNewOrder =
                    {
                    new SqlParameter("@orderID", orderID),
                    new SqlParameter("@itemID", item.ItemID),
                    new SqlParameter("@dateTime", orderTime),
                    new SqlParameter("@comment", item.Comment),
                    new SqlParameter("@quantity", item.Quantity)
                    };

                    // Add item to database
                    ExecuteEditQuery(query, sqlParametersAddToNewOrder);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An issue occurred while trying to place the order.", ex);
            }

        }

        private void CreateNewOrder(int tableNumber, int employeeID)
        {
            try
            {
                // Create query to create a new order in [ORDER] table with the table number and employee ID
                string newOrderQuery = @"INSERT INTO [ORDER] (tableID, employeeID) 
                                        VALUES (@tableNumber, @employeeID)";

                // Set parameters
                SqlParameter[] sqlParameters =
                {
                new SqlParameter("@tableNumber", tableNumber),
                new SqlParameter("@employeeID", employeeID)
                };

                // Create new order in database
                ExecuteEditQuery(newOrderQuery, sqlParameters);
            }
            catch (Exception ex)
            {
                throw new Exception("An issue occurred while trying to create a new order.", ex);
            }
        }

        /* RETRIEVAL OF EXISTING ORDER ID METHODS */
        public int GetOrderID(int tableNumber)
        {
            // Create query for getting the new orderID 
            string query = "SELECT orderID FROM [ORDER] WHERE tableID = @tableNumber AND isPaid = 0;";

            // Set parameters
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@tableNumber", tableNumber)
            };

            // Return the new order ID 
            return ReadOrderIDFromDatabase(ExecuteSelectQuery(query, sqlParameters));
        }

        private int ReadOrderIDFromDatabase(DataTable dataTable)
        {
            // If a record exists 
            if (dataTable != null)
            {
                if (dataTable.Rows.Count > 0)
                {
                    // Return the value
                    return int.Parse(dataTable.Rows[0][0].ToString());
                }
                else 
                { 
                    // If no records exists, return 0
                    return 0; 
                }
            }
            else
            {
                throw new Exception("An issue occurred trying to retrieve the order ID from the database.");
            }
        }

        // Get items from orders
        public List<OrderItem> GetOrderItems()
        {
            // Create query
            string query = @"SELECT O.orderID, tableID, orderItemID, OI.itemID, orderTime, quantity, itemNameShort FROM [ORDER] AS O 
                                                JOIN [ORDER_ITEM] AS OI
                                                ON O.orderID = OI.orderID
                                                JOIN [MENU_ITEM] AS MI
                                                ON OI.itemID = MI.itemID
                                                WHERE isServed =  0 AND isPaid = 0;";

            return ReadTableOrders(ExecuteSelectQuery(query));
        }

        // Create a list with all the items of an order
        private List<OrderItem> ReadTableOrders(DataTable dataTable)
        {
            List<OrderItem> orderItems = new List<OrderItem>();
               
            if (dataTable != null)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    OrderItem item = new OrderItem()
                    {
                        OrderID = (int)row["orderID"],
                        TableID = (int)row["tableID"],
                        OrderItemID = (int)row["orderItemID"],
                        ItemID = (int)row["itemID"],
                        OrderTime = (DateTime)row["orderTime"],
                        Quantity = (int)row["quantity"],
                        ItemName = (string)row["itemNameShort"],
                    };
                    orderItems.Add(item);
                }                
            }
            return orderItems;
        }

        public void SetOrderServed(int orderItemID)
        {
            // Creating query
            string query = @"UPDATE [ORDER_ITEM]
                            SET isServed = 1
                            WHERE orderItemID = @orderItemID;";

            // Set sql parameter
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@orderItemID", orderItemID)
            };

            // Excuting query
            ExecuteEditQuery(query, sqlParameters);
        }
    }
}
