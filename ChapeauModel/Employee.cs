using System;
using System.Collections.Generic;
using System.Text;

namespace ChapeauModel
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeRole { get; set; }
        public string Salt { get; set; }
        public string Hash { get; set; }
    }
}
