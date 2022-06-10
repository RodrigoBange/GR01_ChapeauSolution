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
            // Create query
            string query = "SELECT orderID FROM [ORDER] WHERE tableID = @tableNumber AND isPaid = @isPaid;";

            // Set parameters
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@tableNumber", tableNumber),
                new SqlParameter("@isPaid", (object)0)
            };

            // Check if order exists and save orderID
            int orderID = RunningOrderExists(ExecuteSelectQuery(query, sqlParameters));

            // Check if order already exists and return value
            if (orderID != 0)
            {
                AddToExistingOrder(orderItems, orderID);
            }
            else
            {
                AddNewOrder(orderItems, tableNumber, employeeID);
            }
        }

        private int RunningOrderExists(DataTable dataTable)
        {
            // If a record has been found return the orderID
            if (dataTable.Rows.Count > 0)
            {
                return int.Parse(dataTable.Rows[0]["orderID"].ToString());
            }
            else { return 0; }
        }

        private void AddToExistingOrder(List<OrderItem> orderItems, int orderID)
        {
            foreach (OrderItem item in orderItems)
            {
                // Else if order already exists
                string addToExistingOrderQuery = @"IF EXISTS (SELECT 1 FROM ORDER_ITEMS WHERE orderID = @orderID AND ItemID = @itemID) 
                                                UPDATE ORDER_ITEMS 
                                                SET quantity = quantity + @quantity WHERE orderID = @orderID AND itemID = @itemID 
                                                ELSE 
                                                INSERT INTO ORDER_ITEMS (orderID, itemID, orderTime, comment) 
                                                VALUES (@orderID, @itemID, @dateTime, @comment)";

                // Set parameters
                SqlParameter[] sqlParametersAddToExistingOrder =
                {
                    new SqlParameter("@orderID", orderID),
                    new SqlParameter("@itemID", item.ItemID),
                    new SqlParameter("@quantity", item.Quantity),
                    new SqlParameter("@dateTime", DateTime.Now),
                    new SqlParameter("@comment", item.Comment)
                };


                // Update row or add row to database
                ExecuteEditQuery(addToExistingOrderQuery, sqlParametersAddToExistingOrder);
            }
        }

        private void AddNewOrder(List<OrderItem> orderItems ,int tableNumber, int employeeID)
        {
            // Create query 
            string newOrderQuery = @"INSERT INTO [ORDER] (tableID, employeeID) 
                                    VALUES (@tableNumber, @employeeID)";

            // Set parameters
            SqlParameter[] sqlParametersNewOrder =
            {
                new SqlParameter("@tableNumber", tableNumber),
                new SqlParameter("@employeeID", employeeID)
            };

            try
            {
                // Create new order in database
                ExecuteEditQuery(newOrderQuery, sqlParametersNewOrder);
            }
            catch(Exception ex)
            {
                throw new Exception("There is an issue creating a new order.");
            }


            // Get the new MaxOrderID
            int maxOrderID = GetMaxOrderID();

            foreach (OrderItem item in orderItems)
            {
                // Create query
                string addToNewestOrderQuery = @"INSERT INTO [ORDER_ITEMS] (orderID, itemID, orderTime, comment) 
                                                VALUES (@maxOrderID, @itemID, @dateTime, @comment)";

                // Set parameters for new order
                SqlParameter[] sqlParametersAddToNewOrder =
                {
                    new SqlParameter("@maxOrderID", maxOrderID),
                    new SqlParameter("@itemID", item.ItemID),
                    new SqlParameter("@dateTime", DateTime.Now),
                    new SqlParameter("@comment", item.Comment)
                };

                try
                {
                    // Add item to database
                    ExecuteEditQuery(addToNewestOrderQuery, sqlParametersAddToNewOrder);
                }
                catch (Exception ex)
                {
                    throw new Exception("There is an issue adding items to new order.");
                }

            }
        }

        private int GetMaxOrderID()
        {
            // Create query
            string query = @"SELECT MAX(orderID) AS 'maxID' from [ORDER]";

            try
            {
                // Return value
                return ReadMaxOrderID(ExecuteSelectQuery(query, new SqlParameter[0]));
            }
            catch (Exception ex)
            {
                throw new Exception("There is an issue receiving the newest orderID");
            }

        }

        private int ReadMaxOrderID(DataTable datatable)
        {
            // If a record exists
            if (datatable.Rows.Count > 0)
            {
                // Return the value
                return int.Parse(datatable.Rows[0]["maxID"].ToString());
            }
            else { return 0; }
        }

        public bool CheckOrderStatus(int tableNumber)
        {
            // Create query 
            string query = "SELECT orderID FROM [ORDER] WHERE tableID = @tableNumber AND isPaid = @isPaid;";

            // Set SqlParameter
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@tableNumber", tableNumber),
                new SqlParameter("@isPaid", (object)0)
            };

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

        // Get items from orders
        public List<OrderItem> GetOrderItems()
        {
            // Create query
            string query = @"SELECT O.orderID, tableID, orderItemID, OI.itemID, orderTime, quantity, itemNameShort FROM [ORDER] AS O 
                                                JOIN [ORDER_ITEMS] AS OI
                                                ON O.orderID = OI.orderID
                                                JOIN [MENU_ITEM] AS MI
                                                ON OI.itemID = MI.itemID
                                                WHERE isServed = 0;";

            return ReadTableOrders(ExecuteSelectQuery(query, new SqlParameter[0]));
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
