using System;
using System.Collections.Generic;
using System.Text;
//(`Id`, `OrderDate`, `CustomerId`, `Customer`, `OrderItems`)
namespace EntityTask.Models
{
    public class Order
    {
        public int id { get; set; }
        public DateTime orderDate { get; set; }
        public int customerId { get; set; }
        public Customer customer { get; set; }
        public List<OrderItem> orderItems { get; set; } = new();
    }
}
