using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BusinessEntities
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public ProductCategorie ProductCategory { get; set; }
        public int ProductPrice { get; set; }
        public int ProductIventoryLimit { get; set; }
        public int ProductIventoryLeft { get; set; }
        public string Image { get; set; }

    }
}
