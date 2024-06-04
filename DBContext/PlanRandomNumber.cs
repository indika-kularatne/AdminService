using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class PlanRandomNumber
    {
        public PlanRandomNumber()
        {
            PlanSerial = new HashSet<PlanSerial>();
        }

        public short Id { get; set; }
        public string RandomNumberName { get; set; }
        public int MinNumber { get; set; }
        public int MaxNumber { get; set; }
        public string Position { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public short StatusId { get; set; }

        public virtual ICollection<PlanSerial> PlanSerial { get; set; }
    }
}
