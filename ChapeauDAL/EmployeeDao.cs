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
        public List<Employee> GetAllEmployees(string query)
        {
            // Set SqlParameter
            SqlParameter[] sqlParameters = new SqlParameter[0];

            // Return result of query
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Employee> ReadTables(DataTable dataTable)
        {
            // Create new list of employees
            List<Employee> employees = new List<Employee>();

            try
            {
                //For each data row, create new employee and fill the data
                foreach (DataRow dr in dataTable.Rows)
                {
                    Employee employee = new Employee()
                    {
                        EmployeeName = (string)dr["employeeName"],
                        EmployeeRole = (string)dr["employeeRole"],
                        Email = (string)dr["email"],
                        Salt = (string)dr["passwordSalt"],
                        Hash = (string)dr["passwordHash"],
                        IsFirstLogin = (bool)dr["isFirstLogin"],
                        SecurityQuestion = (string)dr["securityQuestion"],
                        SecurityAnswer = (string)dr["securityAnswer"]
                    };

                    // Add new employee to the list
                    employees.Add(employee);
                }
            }
            catch (Exception ex)
            {
                // Throw exception
                throw new Exception("There is an issue reading the employee data from the database.");
            }

            // Return list of employees
            return employees;
        }
    }
}
