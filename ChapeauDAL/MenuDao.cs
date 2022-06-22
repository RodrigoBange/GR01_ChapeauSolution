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
                                JOIN MENU_ITEM_MENU AS MIM ON M.itemID = MIM.itemID 
                                WHERE MIM.menuID = 1 
                                ORDER BY CASE WHEN M.itemType LIKE 'Starters%' THEN '1' 
                                WHEN M.itemType LIKE 'Mains%' THEN '2' WHEN M.itemType LIKE 'Desserts%' THEN '3' END ASC, M.itemName;";
                    }
                    break;
                case MenuCategory.Dinner:
                    {
                        query = @"SELECT M.itemID, M.itemName, M.itemNameShort, M.itemType, M.price FROM MENU_ITEM AS M 
                                JOIN MENU_ITEM_MENU AS MIM ON M.itemID = MIM.itemID 
                                WHERE MIM.menuID = 2 
                                ORDER BY CASE WHEN M.itemType LIKE 'Starters%' THEN '1' 
                                WHEN M.itemType LIKE 'Entremets%' THEN '2' WHEN M.itemType LIKE 'Mains%' THEN '3' 
                                WHEN M.itemType LIKE 'Desserts%' THEN '4' END ASC, M.itemName;";
                    }
                    break;
                case MenuCategory.Drinks:
                    {
                        query = @"SELECT M.itemID, M.itemName, M.itemNameShort, M.itemType, M.price FROM MENU_ITEM AS M 
                                JOIN MENU_ITEM_MENU AS MIM ON M.itemID = MIM.itemID 
                                WHERE MIM.menuID = 3
                                ORDER BY CASE WHEN M.itemType LIKE 'Soft%' THEN '1' 
                                WHEN M.itemType LIKE 'Beers%' THEN '2' WHEN M.itemType LIKE 'Wines by the glass%' THEN '3' 
                                WHEN M.itemType LIKE 'Wines by the bottle%' THEN '4' WHEN M.itemType LIKE 'Spirit%' THEN '5' 
                                WHEN M.itemType LIKE 'Coffee%' THEN '6' END ASC, M.itemName;";
                    }
                    break;
            }

            // Return result of query with list 
            return ReadTables(ExecuteSelectQuery(query));
        }

        private List<MenuItem> ReadTables(DataTable dataTable)
        {
            // If datatable contains values...
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                // Create new list of MenuItem objects
                List<MenuItem> menuItems = new List<MenuItem>();

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

                // Return list of menu items 
                return menuItems;
            }
            else
            {
                throw new Exception("An issue occurred while trying to retrieve the menu data from the database.");
            }
        }
    }
}
