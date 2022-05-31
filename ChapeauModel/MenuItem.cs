using System;
using System.Collections.Generic;
using System.Text;

namespace ChapeauModel
{
    public class MenuItem
    {
        // Properties
        public int ItemID { get; set; }
        public string FullName { get; set; }
        public string ShortName { get; set; }
        public string Category { get; set; }
        public string SubCategory { get; set; }
        public double Price { get; set; }
    }
}
