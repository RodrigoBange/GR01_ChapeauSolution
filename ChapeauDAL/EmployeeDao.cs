using System;
using System.Collections.Generic;
using System.Text;
using ChapeauModel;
using System.Data.SqlClient;
using System.Data;

namespace ChapeauDAL
{
    public class EmployeeDao : BaseDao
    {
        public Employee GetEmployee(int employeeID)
        {
            string query = $@"SELECT employeeID, passwordSalt, passwordHash, employeeName, employeeRole FROM [EMPLOYEE] 
                            WHERE employeeID = @employeeID;";

            // Set SqlParameter
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@employeeID", employeeID);

            // Return result of query
            return GetEmployeeInfo(ExecuteSelectQuery(query, sqlParameters));
        }

        private Employee GetEmployeeInfo(DataTable dataTable)
        {
            if (dataTable.Rows.Count > 0)
            {
                // Create new list of employees
                Employee employee = new Employee()
                {
                    EmployeeId = (int)dataTable.Rows[0]["employeeID"],
                    EmployeeName = (string)dataTable.Rows[0]["employeeName"],
                    EmployeeRole = (string)dataTable.Rows[0]["employeeRole"],
                    Salt = (string)dataTable.Rows[0]["passwordSalt"],
                    Hash = (string)dataTable.Rows[0]["passwordHash"],
                };
                // Return employee
                return employee;
            }
            else
            { 
                return null;
            }
        }

        public void CreateUser(string name, string role, string salt, string digest)
        {
        string query = $"INSERT INTO [EMPLOYEE] (employeeName, employeeRole, passwordSalt, passwordHash) VALUES (@employeeName, @employeeRole, @passwordSalt, @passwordHash)";

            // Set SqlParameter
            SqlParameter[] sqlParameters = new SqlParameter[4];
            sqlParameters[0] = new SqlParameter("@employeeName", name);
            sqlParameters[1] = new SqlParameter("@employeeRole", role);
            sqlParameters[2] = new SqlParameter("@passwordSalt", salt);
            sqlParameters[3] = new SqlParameter("@passwordHash", digest);

            ExecuteEditQuery(query, sqlParameters);
        }
    }
}
