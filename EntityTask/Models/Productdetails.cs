using System;
using System.Collections.Generic;
using System.Text;
//`Id`, `SKU`, `WarrantyInfo`, `ProductId`, `Product`.
namespace EntityTask.Models
{
    public class Productdetails
    {
        public int id { get; set; }
        public string SKU { get; set; }
        public string WarrantyInfo { get; set; }
        public int productId { get; set; }
        public Product product { get; set; }
    }
}
