using System;
using System.Collections.Generic;
using System.Text;

namespace ChapeauModel
{
    public class Table
    {
        public int TableID { get; set; }
        public bool IsOccupied { get; set; }

        public Table(int tableID, bool isOccupied)
        {
            TableID = tableID;
            IsOccupied = isOccupied;
        }   
    }
}
