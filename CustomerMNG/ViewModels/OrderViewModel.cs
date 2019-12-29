using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using CustomerMNG.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CustomerMNG.ViewModels
{
    public class OrderViewModel:BaseModel
    {
        [Display(Name="Serial")]
        public int NumberOfOrder { get; set; }
        public DateTime PurchaseDate { get; set; }
        public List<Guid> ProductIds { get; set; }
        public List<SelectListItem> ProductSelections { get; set; }
        [Display(Name = "ListProduct")]
        public List<ProductOrder> ProductOrders { get; set; }
    }
}
