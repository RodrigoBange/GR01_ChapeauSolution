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
            // Initialise
            orderDAO = new OrderDao();
        }

        public void PlaceOrder(List<OrderItem> orderItems, int tableNumber, int employeeID)
        {
            // Call orderDAO to place order
            orderDAO.PlaceOrder(orderItems, tableNumber, employeeID);
        }

        public bool CheckOrderStatus(int tableNumber)
        {
            // Call orderDAO to check if order exists
            return orderDAO.CheckOrderStatus(tableNumber);
        }

        public List<OrderItem> GetOrderItems()
        {
            return orderDAO.GetOrderItems();
        }
    }
}
