using System;
using System.Collections.Generic;
using System.Text;

namespace ChapeauModel
{
    public class OrderItem
    {
        // Fields
        public string comment = ""; 

        // Properties
        public int ItemID { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public int OrderID { get; set; }
        public string Comment 
        { 
            get { return comment; }
            set 
            { 
                if (value != "")
                {
                    comment = value;
                }
            }
        }

        // Constructor
        public OrderItem(int itemID, double price)
        {
            ItemID = itemID;
            Price = price;  

            // Set default quantity
            Quantity = 1; 
        }
    }
}
