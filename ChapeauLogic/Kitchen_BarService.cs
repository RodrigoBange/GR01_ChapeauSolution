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
    }
}
