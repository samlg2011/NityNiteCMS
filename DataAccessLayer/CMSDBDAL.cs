using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using BusinessEntities;

namespace DataAccessLayer
{
    public class CMSDBDAL:DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Content> Contents { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().ToTable("TblEmployee");
            modelBuilder.Entity<Customer>().ToTable("TblCustomer");
            modelBuilder.Entity<Product>().ToTable("TblProduct");
            modelBuilder.Entity<Content>().ToTable("TblContent");
            base.OnModelCreating(modelBuilder);
        }
    }
}
