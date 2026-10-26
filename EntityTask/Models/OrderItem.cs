using System;
using System.Collections.Generic;
using System.Text;

namespace EntityTask.Models
{
    public class OrderItem
    {
        public int orderId { get; set; }
        public int productId { get; set; }

        public Order order { get; set; }
        public Product Product { get; set; }

        public int quantity { get; set; }
    }
}
