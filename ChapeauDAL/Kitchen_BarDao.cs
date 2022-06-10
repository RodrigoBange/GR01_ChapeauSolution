using System;
using System.Collections.Generic;
using System.Text;
using ChapeauDAL;
using ChapeauModel;
using System.Data;
using System.Data.SqlClient;

namespace ChapeauDAL
{
    public class Kitchen_BarDao : BaseDao
    {
        //Gets all items
        public List<KitchenBar> GetBarItems()
        {
            string query = "SELECT [ORDER].orderID AS [orderId], itemType AS [item_Type], itemNameShort AS [ShortName], quantity AS [Quantity], comment AS [Comment], orderTime AS [Date_Time], isServed AS [Status], [DRINKS_MENU].itemID AS isDrink FROM [ORDER] JOIN [ORDER_ITEMS] on ORDER_ITEMS.orderID=[ORDER].orderID JOIN [MENU_ITEM] on [MENU_ITEM].itemID=[ORDER_ITEMS].itemID JOIN [DRINKS_MENU] on [DRINKS_MENU].itemID=[ORDER_ITEMS].itemID ORDER BY [ORDER].orderID, Menu_Item.itemID;";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadBarItems(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<KitchenBar> GetLunchItems()
        {
            string query = "SELECT [ORDER].orderID AS [orderId], itemType AS [item_Type], itemNameShort AS [ShortName], quantity AS [Quantity], comment AS [Comment], orderTime AS [Date_Time], isServed AS [Status] FROM [ORDER] JOIN [ORDER_ITEMS] on ORDER_ITEMS.orderID=[ORDER].orderID JOIN [MENU_ITEM] on [MENU_ITEM].itemID=[ORDER_ITEMS].itemID JOIN [LUNCH_MENU] on [LUNCH_MENU].itemID=[ORDER_ITEMS].itemID ORDER BY [ORDER].orderID, Menu_Item.itemID;";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadLunchItems(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<KitchenBar> GetDinnerhItems()
        {
            string query = "SELECT [ORDER].orderID AS [orderId], itemType AS [item_Type], itemNameShort AS [ShortName], quantity AS [Quantity], comment AS [Comment], orderTime AS [Date_Time], isServed AS [Status] FROM [ORDER] JOIN [ORDER_ITEMS] on ORDER_ITEMS.orderID=[ORDER].orderID JOIN [MENU_ITEM] on [MENU_ITEM].itemID=[ORDER_ITEMS].itemID JOIN [DINNER_MENU] on [DINNER_MENU].itemID=[ORDER_ITEMS].itemID ORDER BY [ORDER].orderID, Menu_Item.itemID;";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadDinnerItems(ExecuteSelectQuery(query, sqlParameters));
        }



        private List<KitchenBar> ReadLunchItems(DataTable dataTable)
        {
            List<KitchenBar> LunchItems = new List<KitchenBar>();

            try
            {
                foreach (DataRow dr in dataTable.Rows)
                {
                    KitchenBar LunchItem = new KitchenBar()
                    {
                        OrderID = (int)dr["orderId"],
                        Item_Type = (string)dr["item_Type"],
                        ShortName = (string)dr["ShortName"],
                        Quantity = (int)dr["Quantity"],
                        Date_Time = (DateTime)dr["Date_Time"],
                        Status = (bool)dr["Status"],
                        Comment = (string)dr["Comment"],
                    };
                    LunchItems.Add(LunchItem);
                }
                return LunchItems;
            }

            catch (Exception)
            {
                // Throw exception
                throw new Exception("Something went wrong while reading the items data from the database.");
            }
        }
        private List<KitchenBar> ReadDinnerItems(DataTable dataTable)
        {
            List<KitchenBar> DinnerItems = new List<KitchenBar>();

            try
            {
                foreach (DataRow dr in dataTable.Rows)
                {
                    KitchenBar DinnerItem = new KitchenBar()
                    {
                        OrderID = (int)dr["orderId"],
                        Item_Type = (string)dr["item_Type"],
                        ShortName = (string)dr["ShortName"],
                        Quantity = (int)dr["Quantity"],
                        Date_Time = (DateTime)dr["Date_Time"],
                        Status = (bool)dr["Status"],
                        Comment = (string)dr["Comment"],
                    };
                    DinnerItems.Add(DinnerItem);
                }
                return DinnerItems;
            }

            catch (Exception)
            {
                // Throw exception
                throw new Exception("Something went wrong while reading the items data from the database.");
            }
        }
        private List<KitchenBar> ReadBarItems(DataTable dataTable)
        {
            List<KitchenBar> BarItems = new List<KitchenBar>();

            try
            {
                foreach (DataRow dr in dataTable.Rows)
                {
                    KitchenBar BarItem = new KitchenBar()
                    {
                        OrderID = (int)dr["orderId"],
                        Item_Type = (string)dr["item_Type"],
                        ShortName = (string)dr["ShortName"],
                        Quantity = (int)dr["Quantity"],
                        Date_Time = (DateTime)dr["Date_Time"],
                        Status = (bool)dr["Status"],
                        Comment = (string)dr["Comment"],
                    };
                    BarItems.Add(BarItem);
                }
                return BarItems;
            }

            catch (Exception)
            {
                // Throw exception
                throw new Exception("Something went wrong while reading the items data from the database.");
            }
        }


    }
}
