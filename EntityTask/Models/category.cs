using System;
using System.Collections.Generic;
using System.Text;

namespace EntityTask.Models
{
    public class category
    {
        public int id { get; set; }
        public string name { get; set; }

        public List<Product> products { get; set; } = new();
    }
}
