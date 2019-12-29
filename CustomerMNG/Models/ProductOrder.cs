using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerMNG.Models
{
    public class ProductOrder
    {
        public Product Product { get; set; }
        public Order Order { get; set; }
        public Guid ProductId { get; set; }
        public  Guid OrderId { get; set; }
    }
}
