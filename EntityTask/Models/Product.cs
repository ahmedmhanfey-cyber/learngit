using System;
using System.Collections.Generic;
using System.Text;

namespace EntityTask.Models
{
    public class Product
    {
        public int id { get; set; } 
        public string name { get; set; }

        public decimal price { get; set; }
        public int categoryId { get; set; }
      

        public Productdetails productdetail { get; set; }
        public List<OrderItem> OrderItems { get; set; } = new();
    }
}
