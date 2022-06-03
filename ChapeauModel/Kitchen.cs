using System;
using System.Collections.Generic;
using System.Text;

namespace ChapeauModel
{
    public class Kitchen
    {
        // Fields
        public string comment = "";

        // Properties
        public int OrderID { get; set; }
        public string Type { get; set; }
        public string ShortName { get; set; }
        public int Quantity { get; set; }
        public DateTime DateTime { get; set; }
        public bool Status { get; set; }
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
