using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerMNG.Models
{
    public class BaseModel
    {
        public BaseModel()
        {
            Id = Guid.NewGuid();
            CreatedDate = DateTime.UtcNow;
        }
        [Key]
        public Guid Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpDatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
    }
}
