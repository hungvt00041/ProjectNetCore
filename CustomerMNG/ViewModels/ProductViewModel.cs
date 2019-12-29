using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using CustomerMNG.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CustomerMNG.ViewModels
{
    public class ProductViewModel:BaseModel
    {
        [DisplayName("Tên")]
        public string Name { get; set; }
        public string ProductViewName { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public double TotalPrice { get; set; }

        public Guid CategoryId { get; set; }

        public Category Category { get; set; }
        public List<SelectListItem> CategorySelections { get; set; }
    }
}
