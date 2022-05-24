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
    }
}
