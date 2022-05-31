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

        public List<Employee> GetAllEmployees()
        {
            // Get list of employees
            List<Employee> employees = employeeDao.GetAllEmployees("SELECT employeeName, employeeRole, email, passwordSalt, passwordHash, isFirstLogin, securityQuestion, securityAnswer FROM [EMPLOYEE]");

            // Return list
            return employees;
        }
    }
}
