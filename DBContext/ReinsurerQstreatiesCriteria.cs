using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class ReinsurerQstreatiesCriteria
    {
        public Guid Id { get; set; }
        public Guid QstId { get; set; }
        public string Condition { get; set; }
        public string Jsoncolumn { get; set; }
        public string Input { get; set; }
        public string FixedValue { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Name { get; set; }

        public virtual ReinsurerQstreaties Qst { get; set; }
    }
}
