using ChapeauDAL;
using ChapeauModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChapeauLogic
{
    public class OrderService
    {
        // DAL 
        OrderDao orderDAO;

        // Constructor
        public OrderService()
        {
            // Create new orderDao
            orderDAO = new OrderDao();
        }

        public List<MenuItem> GetMenuItems(MenuCategory category)
        {
            // Create new query depending on what category items are required
            string query = ""; 

            switch (category)
            {
                case MenuCategory.Lunch:
                    {
                        query = "SELECT M.itemName, M.itemType, M.price FROM MENU_ITEM AS M JOIN LUNCH_MENU AS L ON M.itemID = L.itemID ORDER BY CASE WHEN M.itemType LIKE 'Starters%' THEN '1' WHEN M.itemType LIKE 'Mains%' THEN '2' WHEN M.itemType LIKE 'Desserts%' THEN '3' END ASC, M.itemName; ";
                    }
                    break;
                case MenuCategory.Dinner:
                    {
                        query = "SELECT M.itemName, M.itemType, M.price FROM MENU_ITEM AS M JOIN DINNER_MENU AS D ON M.itemID = D.itemID ORDER BY CASE WHEN M.itemType LIKE 'Starters%' THEN '1' WHEN M.itemType LIKE 'Entrements%' THEN '2' WHEN M.itemType LIKE 'Mains%' THEN '3' WHEN M.itemType LIKE 'Desserts%' THEN '4' END ASC, M.itemName; ";
                    }
                    break;
                case MenuCategory.Drinks:
                    {
                        query = "SELECT M.itemName, M.itemType, M.price FROM MENU_ITEM AS M JOIN DRINKS_MENU AS D ON M.itemID = D.itemID ORDER BY CASE WHEN M.itemType LIKE 'Soft%' THEN '1' WHEN M.itemType LIKE 'Beers%' THEN '2' WHEN M.itemType LIKE 'Wines by the glass%' THEN '3' WHEN M.itemType LIKE 'Wines by the bottle%' THEN '4' WHEN M.itemType LIKE 'Spirit%' THEN '5' WHEN M.itemType LIKE 'Coffee%' THEN '6' END ASC, M.itemName; ";
                    }
                    break;
            }

            // Get list of all products 
            List<MenuItem> menuList = orderDAO.GetMenuItems(query);

            // Return list
            return menuList;
        }
    }
}
