using System;
using System.Collections.Generic;

namespace ChapeauModel
{
    public class KitchenBar
    {
        // Fields
        public string comment = "";

        // Properties
        public int OrderID { get; set; }
        public string Item_Type { get; set; }
        public string ShortName { get; set; }
        public int Quantity { get; set; }
        public DateTime Date_Time { get; set; }
        public bool Status { get; set; }
        public int orderItemID { get; set; }
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
    }
}
