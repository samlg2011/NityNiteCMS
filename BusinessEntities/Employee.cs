using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BusinessEntities
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SIN { get; set; }
        public AuthStatus EmployeeType { get; set; }
        public string EmployeeStartDate { get; set; }
        public string EmployeeEndDate { get; set; }
        public string EmployeePhone { get; set; }
        public string EmployeeMobile { get; set; }
        public int EmployeeStreetNum { get; set; }
        public string EmployeeStreetName { get; set; }
        public string EmployeeProvince { get; set; }
        public string EmployeePostCode { get; set; }
        public int EmployeeSalary { get; set; }
    }
}
