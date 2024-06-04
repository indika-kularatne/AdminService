using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class TaskSchedulerLog
    {
        public Guid Id { get; set; }
        public Guid TaskId { get; set; }
        public DateTime ActionDate { get; set; }
        public bool IsSuccess { get; set; }

        public virtual TaskSchedulerJob Task { get; set; }
    }
}
