using ChapeauModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace ChapeauDAL
{
    public class MenuDao : BaseDao
    {
        public List<MenuItem> GetMenuItems(MenuCategory category)
        {
            // Decide query here 
            string query = "";

            // Set query to collect menu items 
            switch (category)
            {
                case MenuCategory.Lunch:
                    {
                        query = @"SELECT M.itemID, M.itemName, M.itemNameShort, M.itemType, M.price FROM MENU_ITEM AS M 
                                JOIN LUNCH_MENU AS L ON M.itemID = L.itemID ORDER BY CASE WHEN M.itemType LIKE 'Starters%' THEN '1' 
                                WHEN M.itemType LIKE 'Mains%' THEN '2' WHEN M.itemType LIKE 'Desserts%' THEN '3' END ASC, M.itemName; ";
                    }
                    break;
                case MenuCategory.Dinner:
                    {
                        query = @"SELECT M.itemID, M.itemName, M.itemNameShort, M.itemType, M.price FROM MENU_ITEM AS M 
                                JOIN DINNER_MENU AS D ON M.itemID = D.itemID ORDER BY CASE WHEN M.itemType LIKE 'Starters%' THEN '1' 
                                WHEN M.itemType LIKE 'Entrements%' THEN '2' WHEN M.itemType LIKE 'Mains%' THEN '3' WHEN M.itemType LIKE 'Desserts%' THEN '4' END ASC, M.itemName; ";
                    }
                    break;
                case MenuCategory.Drinks:
                    {
                        query = @"SELECT M.itemID, M.itemName, M.itemNameShort, M.itemType, M.price FROM MENU_ITEM AS M 
                                JOIN DRINKS_MENU AS D ON M.itemID = D.itemID ORDER BY CASE WHEN M.itemType LIKE 'Soft%' THEN '1' 
                                WHEN M.itemType LIKE 'Beers%' THEN '2' WHEN M.itemType LIKE 'Wines by the glass%' THEN '3' 
                                WHEN M.itemType LIKE 'Wines by the bottle%' THEN '4' WHEN M.itemType LIKE 'Spirit%' THEN '5' 
                                WHEN M.itemType LIKE 'Coffee%' THEN '6' END ASC, M.itemName; ";
                    }
                    break;
            }

            // Return result of query with list 
            return ReadTables(ExecuteSelectQuery(query, new SqlParameter[0]));
        }

        private List<MenuItem> ReadTables(DataTable dataTable)
        {
            // Create new list of MenuItem objects
            List<MenuItem> menuItems = new List<MenuItem>();

            // If datatable contains values...
            if (dataTable != null)
            {
                // For each data row, create new MenuItem object and fill data
                foreach (DataRow dr in dataTable.Rows)
                {
                    MenuItem item = new MenuItem()
                    {
                        ItemID = (int)dr["itemID"],
                        FullName = (string)dr["itemName"],
                        ShortName = (string)dr["itemNameShort"],
                        SubCategory = (string)dr["itemType"],
                        Price = (double)(decimal)dr["price"]
                    };

                    // Add new MenuItem object to the list of menu items 
                    menuItems.Add(item);
                }
            }
            else
            {
                throw new Exception("There is an issue retrieving the menu data from the database.");
            }

            // Return list of menu items 
            return menuItems;
        }
    }
}
