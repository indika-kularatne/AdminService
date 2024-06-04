using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class EltSettings
    {
        public EltSettings()
        {
            EltProcessFlows = new HashSet<EltProcessFlows>();
            EltSettingLog = new HashSet<EltSettingLog>();
            EltSettingNotification = new HashSet<EltSettingNotification>();
        }

        public Guid Id { get; set; }
        public string FileXferName { get; set; }
        public short? FileXferPortocol { get; set; }
        public string FileXferHost { get; set; }
        public string FileXferPort { get; set; }
        public string FileXferUser { get; set; }
        public string FileXferPassword { get; set; }
        public string FileXferSourcePath { get; set; }
        public string FileXferPattern { get; set; }
        public short? FileXferFormat { get; set; }
        public string FileXferDestinationPath { get; set; }
        public string FileXferDelimiter { get; set; }
        public short? FileXferedOption { get; set; }
        public string FileXferArchivePath { get; set; }
        public short? FileXferRowStart { get; set; }
        public short? FileXferDuplicate { get; set; }
        public string FileXferTable { get; set; }
        public short? FileXferTableColumnType { get; set; }
        public short? FileXferFileStart { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public Guid? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public short StatusId { get; set; }

        public virtual ICollection<EltProcessFlows> EltProcessFlows { get; set; }
        public virtual ICollection<EltSettingLog> EltSettingLog { get; set; }
        public virtual ICollection<EltSettingNotification> EltSettingNotification { get; set; }
    }
}
