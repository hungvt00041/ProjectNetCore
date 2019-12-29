using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerMNG.Models
{
    public class Order:BaseModel
    {
        public Order()
        {
            ProductOrders = new List<ProductOrder>();
        }
        public int NumberOfOrder { get; set; }
        public DateTime PurchaseDate { get; set; }
        public List<ProductOrder> ProductOrders { get; set; }
    }
}
