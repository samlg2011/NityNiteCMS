using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using BusinessEntities;
using System.Data.Entity;


namespace BusinessLayer
{
    public class EmployeeBusinessLayer
    {
        private CMSDBDAL cmsDal = new CMSDBDAL();
        public List<Employee> GetEmployee()
        {
            
            return cmsDal.Employees.ToList();
        }
        public Employee FindEmployee(int? id)
        {
            return cmsDal.Employees.Find(id);
        }
        public void CreateEmployee(Employee employee)
        {
            cmsDal.Employees.Add(employee);
            cmsDal.SaveChanges();
        }

        public void EditEmployee(Employee employee)
        {
            cmsDal.Entry(employee).State = EntityState.Modified;
            cmsDal.SaveChanges();
        }
        public void DeleteEmployee(int id)
        {
            Employee employee = FindEmployee(id);
            cmsDal.Employees.Remove(employee);
            cmsDal.SaveChanges();
        }
        public void DeleteEmployee(Employee employee)
        {
            cmsDal.Employees.Remove(employee);
            cmsDal.SaveChanges();
        }
    }
}
