using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerMNG.Models
{
    public class Customer
    {
        [Required]
        [StringLength(20)]
        [DisplayName("Tên")]
        public string Name { get; set; }
        [Required]
        [Range(18,40)]
        [DisplayName("Tuổi")]
        public int Age { get; set; }
    }
}
