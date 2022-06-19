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

            // If orderID exists...
            if (orderID != 0)
            {
                // Add new order items
                AddNewOrder(orderItems, orderID);
            }
            else
            {
                // Create a new order in the database
                CreateNewOrder(tableNumber, employeeID);

                // Get the orderID of the new table order from the database
                orderID = GetOrderID(tableNumber);

                // Add new order items
                AddNewOrder(orderItems, orderID);
            }
        }

        /* CREATING NEW ORDER METHODS */
        private void AddNewOrder(List<OrderItem> orderItems, int orderID)
        {
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
                    new SqlParameter("@dateTime", DateTime.Now),
                    new SqlParameter("@comment", item.Comment),
                    new SqlParameter("@quantity", item.Quantity)                    
                };

                // Add item to database
                ExecuteEditQuery(query, sqlParametersAddToNewOrder);
            }
        }

        private void CreateNewOrder(int tableNumber, int employeeID)
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
                    return 0; 
                }
            }
            else
            {
                throw new Exception("An issue occurred retrieving the order ID from the database.");
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
                                                WHERE isServed = 0;";

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
    }
}
