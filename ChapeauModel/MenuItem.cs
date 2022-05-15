using System;
using System.Collections.Generic;
using System.Text;

namespace ChapeauModel
{
    public class MenuItem
    {
        // Variables
        public string comment = ""; 

        // Properties
        public string Name { get; set; }
        public string Category { get; set; }
        public string SubCategory { get; set; }
        public double Price { get; set; }
        public string Comment // Maybe make an order item instead for this?
        { 
            get { return comment; } 
            set 
            { 
                if (comment != "")
                {
                    comment = value;
                }
            } 
        }    
    }
}
