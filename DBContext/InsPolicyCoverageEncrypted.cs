using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class InsPolicyCoverageEncrypted
    {
        public Guid Id { get; set; }
        public Guid PolicyUuid { get; set; }
        public string EncryptedData { get; set; }
        public int KeyVersion { get; set; }
        public string EncryptedKey { get; set; }
        public TimeSpan CreatedDate { get; set; }
    }
}
