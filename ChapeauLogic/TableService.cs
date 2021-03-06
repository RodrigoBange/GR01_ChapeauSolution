using ChapeauDAL;
using ChapeauModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChapeauLogic
{
    public class TableService
    {
        // DAL
        TableDao tableDao;

        public TableService()
        {
            tableDao = new TableDao();
        }

        public bool TableOccupied(int tableNumber)
        {
            // Check if table is occupied
            return tableDao.TableOccupied(tableNumber);
        }

        public void SetTableOccupied(int tableNumber)
        {
            // Set table as occupied
            tableDao.SetTableOccupied(tableNumber);
        }

        public void SetTableUnoccupied(int tableNumber)
        {
            // Set table as unoccupied
            tableDao.SetTableUnOccupied(tableNumber);
        }

        public List<Table> GetAllTables()
        {
            // Get list of tables
            return tableDao.GetAllTables();
        }
    }
}
