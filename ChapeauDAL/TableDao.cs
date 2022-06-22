using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using ChapeauModel;

namespace ChapeauDAL
{
    public class TableDao : BaseDao
    {
        public bool TableOccupied(int tableNumber)
        {
            // Creating qeury
            string query = @"SELECT isOccupied FROM [TABLE]
                             WHERE tableID = @tableID";

            // Set sql parameter
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@tableID", tableNumber)
            };

            // Excuting query
            return GetTableInfo(ExecuteSelectQuery(query, sqlParameters));

        }

        private bool GetTableInfo(DataTable dataTable)
        {
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                return (bool)dataTable.Rows[0]["isOccupied"];
            }
            else
            {
                throw new Exception("Something went wrong while reading table data from the database");
            }
        }

        public void SetTableOccupied(int tableNumber)
        {
            // Creating query
            string query = @"UPDATE [TABLE]
                            SET isOccupied = 1
                            WHERE tableID = @tableNumber;";

            // Set sql parameter
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@tableNumber", tableNumber)
            };

            // Excuting query
            ExecuteEditQuery(query, sqlParameters);
        }

        public void SetTableUnOccupied(int tableNumber)
        {
            // Creating query
            string query = @"UPDATE [TABLE]
                            SET isOccupied = 0
                            WHERE tableID = @tableNumber;";

            // Set sql parameter
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@tableNumber", tableNumber)
            };

            // Excuting query
            ExecuteEditQuery(query, sqlParameters);
        }

        public List<Table> GetAllTables()
        {
            string query = "SELECT tableID, buttonID, isOccupied FROM [TABLE]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return LoadListTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Table> LoadListTables(DataTable dataTable)
        {
            List<Table> tables = new List<Table>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Table table = new Table()
                {
                    TableID = (int)dr["tableID"],
                    ButtonID = (int)dr["buttonID"],
                    IsOccupied = (bool)dr["isOccupied"],
                };
                tables.Add(table);
            }
            return tables;
        }
    }
}
