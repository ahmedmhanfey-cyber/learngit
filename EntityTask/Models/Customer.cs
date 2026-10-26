using System;
using System.Collections.Generic;
using System.Text;
//(`Id`, `Name`, `Email`, `Orders`)
namespace EntityTask.Models
{
    public class Customer
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public List<Order> orders { get; set; } = new();
    }
}
