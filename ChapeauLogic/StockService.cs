using ChapeauDAL;
using ChapeauModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChapeauLogic
{
    public class StockService
    {
        // DAL 
        private StockDao stockDAO;

        // Constructor
        public StockService()
        {
            // Initialise
            stockDAO = new StockDao();
        }

        public void DepleteStock(List<OrderItem> orderItems)
        {
            // call stockDao to deplete stock
            stockDAO.DepleteStock(orderItems);
        }

        public List<string> CheckStorageStatus(List<OrderItem> orderItems)
        {
            // call stockDao to check storage status and return names of low stock items
            return stockDAO.CheckStorageStatus(orderItems);
        }
    }
}
