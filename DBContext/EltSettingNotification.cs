using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class EltSettingNotification
    {
        public Guid Id { get; set; }
        public Guid EltSettingsId { get; set; }
        public string To { get; set; }
        public string Cc { get; set; }
        public string Bcc { get; set; }
        public short? EmailType { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }

        public virtual EltSettings EltSettings { get; set; }
    }
}
