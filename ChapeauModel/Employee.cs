using System;
using System.Collections.Generic;
using System.Text;

namespace ChapeauModel
{
    public class Employee
    {
        public string EmployeeName { get; set; }
        public string EmployeeRole { get; set; }
        public string Email { get; set; }
        public string Salt { get; set; }
        public string Hash { get; set; }
        public bool IsFirstLogin { get; set; }
        public string SecurityQuestion { get; set; }
        public string SecurityAnswer { get; set; }
    }
}
