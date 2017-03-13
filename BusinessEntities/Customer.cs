using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BusinessEntities
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public string CustomerGender { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerStreetNum { get; set; }
        public string CustomerStreetName { get; set; }
        public string CustomerProvince { get; set; }
        public string CustomerPostCode { get; set; }
        public BillingMethod CustomerBillingMethod { get; set; }
    }
}
