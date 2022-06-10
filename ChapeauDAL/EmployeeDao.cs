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
            // Create a new employee
            Employee employee = new Employee();

            try
            {
                if (dataTable.Rows.Count > 0)
                {
                    employee.EmployeeId = (int)dataTable.Rows[0]["employeeID"];
                    employee.EmployeeName = (string)dataTable.Rows[0]["employeeName"];
                    employee.EmployeeRole = (string)dataTable.Rows[0]["employeeRole"];
                    employee.Salt = (string)dataTable.Rows[0]["passwordSalt"];
                    employee.Hash = (string)dataTable.Rows[0]["passwordHash"];
                }
            }
            catch(Exception ex)
            {
                // Throw exception
                throw new Exception("Something went wrong while reading employee data from the database.");
            }

            // Return employee
            return employee;
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
