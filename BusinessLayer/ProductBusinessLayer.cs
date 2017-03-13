using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using BusinessEntities;
using BusinessLayer;
using System.Data.Entity;

namespace BusinessLayer
{
    public class ProductBusinessLayer
    {
        private CMSDBDAL cmsDal = new CMSDBDAL();
        public List<Product> GetProduct()
        {

            return cmsDal.Products.ToList();
        }
        public Product FindProduct(int? id)
        {
            return cmsDal.Products.Find(id);
        }
        public void CreateProduct(Product product)
        {
            cmsDal.Products.Add(product);
            cmsDal.SaveChanges();
        }

        public void EditProduct(Product product)
        {
            cmsDal.Entry(product).State = EntityState.Modified;
            cmsDal.SaveChanges();
        }
        public void DeleteProduct(int id)
        {
            Product product = FindProduct(id);
            cmsDal.Products.Remove(product);
            cmsDal.SaveChanges();
        }
        public void DeleteProduct(Product product)
        {
            cmsDal.Products.Remove(product);
            cmsDal.SaveChanges();
        }
    }
}
