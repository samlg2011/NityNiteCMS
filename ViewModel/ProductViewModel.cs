using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities;
using BusinessLayer;

namespace ViewModel
{
    public class ProductViewModel
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public ProductCategorie ProductCategory { get; set; }
        public int ProductPrice { get; set; }
        public int ProductIventoryLimit { get; set; }
        public int ProductIventoryLeft { get; set; }
        public string ProductIventoryColor { get; set; }
        public string image { get; set; }
    }
}
