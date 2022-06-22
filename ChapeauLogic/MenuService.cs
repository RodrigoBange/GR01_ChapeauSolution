using ChapeauDAL;
using ChapeauModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChapeauLogic
{
    public class MenuService
    {
        // DAL 
        MenuDao menuDAO; 

        // Constructor
        public MenuService()
        {
            // Create new MenuDao
            menuDAO = new MenuDao();
        }

        public List<MenuItem> GetMenuItems(MenuCategory category)
        {
            // Get list of all products of certain menu category
            return menuDAO.GetMenuItems(category);
        }
    }
}
