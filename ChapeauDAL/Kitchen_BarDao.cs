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
            string query = "SELECT [ORDER_ITEM].orderID, itemType, itemNameShort, quantity, comment, orderTime, isServed, orderItemID FROM ORDER_ITEM JOIN MENU_ITEM_MENU on [ORDER_ITEM].itemID=[MENU_ITEM_MENU].itemID JOIN MENU_ITEM on [ORDER_ITEM].itemID=[MENU_ITEM].itemID JOIN MENU on [MENU_ITEM_MENU].menuID=[MENU].menuID WHERE MENU.menuID=3 AND isPrepared!=1;";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadBarItems(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<KitchenBar> GetLunchItems()
        {
            string query = "SELECT [ORDER_ITEM].orderID, itemType, itemNameShort, quantity, comment, orderTime, isServed, orderItemID FROM ORDER_ITEM JOIN MENU_ITEM_MENU on [ORDER_ITEM].itemID=[MENU_ITEM_MENU].itemID JOIN MENU_ITEM on [ORDER_ITEM].itemID=[MENU_ITEM].itemID JOIN MENU on [MENU_ITEM_MENU].menuID=[MENU].menuID WHERE MENU.menuID=1 AND isPrepared!=1;";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadLunchItems(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<KitchenBar> GetDinnerItems()
        {
            string query = "SELECT [ORDER_ITEM].orderID, itemType, itemNameShort, quantity, comment, orderTime, isServed, orderItemID FROM ORDER_ITEM JOIN MENU_ITEM_MENU on [ORDER_ITEM].itemID=[MENU_ITEM_MENU].itemID JOIN MENU_ITEM on [ORDER_ITEM].itemID=[MENU_ITEM].itemID JOIN MENU on [MENU_ITEM_MENU].menuID=[MENU].menuID WHERE MENU.menuID=2 AND isPrepared!=1;";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadDinnerItems(ExecuteSelectQuery(query, sqlParameters));
        }

        public void isPrepared(int orderItemID)
        {
            string query = "UPDATE [ORDER_ITEM] SET IsPrepared=1 WHERE orderItemID=@orderItemID;";

            SqlParameter[] sqlParameters = 
            {
                new SqlParameter("@orderItemID", orderItemID),
            };

            ExecuteEditQuery(query, sqlParameters);
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
                        Item_Type = (string)dr["itemType"],
                        ShortName = (string)dr["itemNameShort"],
                        Quantity = (int)dr["quantity"],
                        Date_Time = (DateTime)dr["orderTime"],
                        Status = (bool)dr["isServed"],
                        Comment = (string)dr["comment"],
                        orderItemID = (int)dr["orderItemID"]
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
                        Item_Type = (string)dr["itemType"],
                        ShortName = (string)dr["itemNameShort"],
                        Quantity = (int)dr["quantity"],
                        Date_Time = (DateTime)dr["orderTime"],
                        Status = (bool)dr["isServed"],
                        Comment = (string)dr["comment"],
                        orderItemID=(int)dr["orderItemID"]
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
                        Item_Type = (string)dr["itemType"],
                        ShortName = (string)dr["itemNameShort"],
                        Quantity = (int)dr["quantity"],
                        Date_Time = (DateTime)dr["orderTime"],
                        Status = (bool)dr["isServed"],
                        Comment = (string)dr["comment"],
                        orderItemID = (int)dr["orderItemID"]
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
