using System;
using System.Collections.Generic;
using System.Text;
using ChapeauDAL;
using ChapeauModel;

namespace ChapeauLogic
{
    public class Kitchen_BarService
    {
        // DAL 
        Kitchen_BarDao kitchen_BarDao;

        // Constructor
        public Kitchen_BarService()
        {
            // Initialise
            kitchen_BarDao = new Kitchen_BarDao();
        }

        public List<KitchenBar> GetBarItems()
        {
            return kitchen_BarDao.GetBarItems();
        }

        public List<KitchenBar> GetLunchItems()
        {
            return kitchen_BarDao.GetLunchItems();
        }

        public List<KitchenBar> GetDinnerItems()
        {
            return kitchen_BarDao.GetDinnerItems();
        }
    }
}
