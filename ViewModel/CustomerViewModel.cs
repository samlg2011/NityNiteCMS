using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities;
using BusinessLayer;

namespace ViewModel
{
    public class CustomerViewModel
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerGender { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerAddress { get; set; }
        public BillingMethod CustomerBillingMethod { get; set; }

        public List<CustomerViewModel> GetCustomerViewModelList()
        {
            CustomerBusinessLayer cutBL = new CustomerBusinessLayer();
            List<Customer> customerList = cutBL.GetCustomer();
            List<CustomerViewModel> cutLVM = new List<CustomerViewModel>();
            foreach(Customer customer in customerList)
            {
                CustomerViewModel cutVM = new CustomerViewModel();
                cutVM.CustomerName = customer.CustomerFirstName + " " + customer.CustomerLastName;
                cutVM.CustomerGender = customer.CustomerGender;
                cutVM.CustomerEmail = customer.CustomerEmail;
                cutVM.CustomerAddress = customer.CustomerStreetNum + " " + customer.CustomerStreetName + ", " + customer.CustomerProvince + ", " + customer.CustomerPostCode;
                cutVM.CustomerBillingMethod = customer.CustomerBillingMethod;
                cutLVM.Add(cutVM);
            }
            return cutLVM;
        }
    }
}
