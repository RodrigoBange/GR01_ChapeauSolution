using System;
using System.Collections.Generic;
using System.Text;
using ChapeauDAL;
using ChapeauModel;

namespace ChapeauLogic
{
    public class EmployeeService
    {
        // DAL
        EmployeeDao employeeDao;

        // Constructor
        public EmployeeService()
        {
            employeeDao = new EmployeeDao();
        }

        public Employee GetEmployee(int employeeID)
        {
            // Get employee by employeeID
            return employeeDao.GetEmployee(employeeID);
        }

        public void CreateEmployee(string name, string role, string salt, string digest)
        {
            employeeDao.CreateUser(name, role, salt, digest);
        }
    }
}
