using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class TaskSchedulerJob
    {
        public TaskSchedulerJob()
        {
            TaskSchedulerLog = new HashSet<TaskSchedulerLog>();
        }

        public Guid Id { get; set; }
        public string Authentication { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string ApiUrl { get; set; }
        public string CronExpressions { get; set; }
        public DateTime CreatedDate { get; set; }
        public long TypeId { get; set; }
        public string RequestBody { get; set; }
        public string ApiTokenUrl { get; set; }
        public bool? IsErrorRerun { get; set; }
        public bool? IsOneTime { get; set; }
        public bool? IsErrorSendEmail { get; set; }
        public string EmailList { get; set; }
        public string TaskName { get; set; }
        public int? JobNo { get; set; }

        public virtual ICollection<TaskSchedulerLog> TaskSchedulerLog { get; set; }
    }
}
