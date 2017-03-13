using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities;
using BusinessLayer;

namespace ViewModel
{
    public class EmployeeViewModel
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string SIN { get; set; }
        public AuthStatus EmployeeType { get; set; }
        public string EmployeeWorkingPeriod { get; set; }
        public string EmployeePhone { get; set; }
        public string EmployeeMobile { get; set; }
        public string EmployeeAddress { get; set; }
        public int EmployeeSalary { get; set; }

        public List<EmployeeViewModel> GetEmployeeViewModelList()
        {
            List<EmployeeViewModel> empViewModels = new List<EmployeeViewModel>();
            EmployeeBusinessLayer empBL = new EmployeeBusinessLayer();
            List<Employee> EmployeeList = empBL.GetEmployee();
            foreach (Employee employee in EmployeeList)
            {
                EmployeeViewModel evm = new EmployeeViewModel();
                evm.EmployeeId = employee.EmployeeId;
                evm.EmployeeName = employee.FirstName + " " + employee.LastName;
                evm.SIN = employee.SIN;
                evm.EmployeeType = employee.EmployeeType;
                evm.EmployeeWorkingPeriod = employee.EmployeeStartDate + " -- " + employee.EmployeeEndDate;
                evm.EmployeePhone = employee.EmployeePhone;
                evm.EmployeeMobile = employee.EmployeeMobile;
                evm.EmployeeAddress = employee.EmployeeStreetNum + " " + employee.EmployeeStreetName + " " + employee.EmployeeProvince + " " + employee.EmployeePostCode;
                evm.EmployeeSalary = employee.EmployeeSalary;
                empViewModels.Add(evm);
            }
            return empViewModels;
        }
    }
}
