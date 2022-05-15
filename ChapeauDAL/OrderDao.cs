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
        public List<MenuItem> GetMenuItems(string query)
        {
            // Set SqlParameter
            SqlParameter[] sqlParameters = new SqlParameter[0];

            // Return result of query
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<MenuItem> ReadTables(DataTable dataTable)
        {
            // Create new list of MenuItem objects
            List<MenuItem> menuItems = new List<MenuItem>();

            try
            {
                // For each data row, create new MenuItem object and fill data
                foreach (DataRow dr in dataTable.Rows)
                {
                    MenuItem item = new MenuItem()
                    {
                        Name = (string)dr["itemName"],
                        SubCategory = (string)dr["itemType"],
                        Price = (double)(decimal)dr["price"]
                    };

                    // Add new MenuItem object to the list of menu items 
                    menuItems.Add(item);
                }
            }
            catch (Exception ex)
            {
                // Throw exception
                throw new Exception("There is an issue reading the menu item data from the database.");
            }

            // Return list of menu items 
            return menuItems;
        }
    }
}
