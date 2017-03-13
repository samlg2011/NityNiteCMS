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
    public class CustomerBusinessLayer
    {
        private CMSDBDAL cmsDal = new CMSDBDAL();
        public List<Customer> GetCustomer()
        {

            return cmsDal.Customers.ToList();
        }
        public Customer FindCustomer(int? id)
        {
            return cmsDal.Customers.Find(id);
        }
        public void CreateCustomer(Customer customer)
        {
            cmsDal.Customers.Add(customer);
            cmsDal.SaveChanges();
        }

        public void EditCustomer(Customer customer)
        {
            cmsDal.Entry(customer).State = EntityState.Modified;
            cmsDal.SaveChanges();
        }
        public void DeleteCustomer(int id)
        {
            Customer customer = FindCustomer(id);
            cmsDal.Customers.Remove(customer);
            cmsDal.SaveChanges();
        }
        public void DeleteCustomer(Customer customer)
        {
            cmsDal.Customers.Remove(customer);
            cmsDal.SaveChanges();
        }
    }
}
