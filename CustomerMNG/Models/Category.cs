using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerMNG.Models
{
    public class Category : BaseModel
    {
        public string Name { get; set; }

        public List<Product> Products { get; set; }

    }
}
