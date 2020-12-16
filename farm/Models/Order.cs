using System;
using System.Collections.Generic;

namespace farm.Models
{
    public class Order
    {
        public int ID { get; set; }

        public Customer Customer { get; set; }

        public List<Product> List { get; set; }

        public DateTime DateTime { get; set; }
    }
}
