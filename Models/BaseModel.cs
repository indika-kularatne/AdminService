using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdminService.Models
{
    public class BaseModel
    {
        public Guid ID { get; set; }

        [Required]
        public Guid CreatedBy { get; set; }

        public string CreatedByName { get; set; }

        public DateTime CreatedDate { get; set; }

        public Guid ModifiedBy { get; set; }

        public string ModifiedByName { get; set; }

        public DateTime ModifiedDate { get; set; }
    }
}
