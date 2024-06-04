using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class SysOrganizations
    {
        public SysOrganizations()
        {
            OrganizationEmployee = new HashSet<OrganizationEmployee>();
            OrganizationEmployeeDocuments = new HashSet<OrganizationEmployeeDocuments>();
            SysAdmin = new HashSet<SysAdmin>();
            SysGatewayAccount = new HashSet<SysGatewayAccount>();
        }

        public string Companyname { get; set; }
        public string Coregno { get; set; }
        public string Addressline1 { get; set; }
        public string Addressline2 { get; set; }
        public string Addressline3 { get; set; }
        public string Postcode { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Officetelephone { get; set; }
        public string Contactperson { get; set; }
        public string Notes { get; set; }
        public DateTime Crdt { get; set; }
        public Guid Crby { get; set; }
        public DateTime? Updt { get; set; }
        public Guid? Upby { get; set; }
        public string Businesschannel { get; set; }
        public Guid Orguuid { get; set; }

        public virtual SysAdmin CrbyNavigation { get; set; }
        public virtual SysAdmin UpbyNavigation { get; set; }
        public virtual ICollection<OrganizationEmployee> OrganizationEmployee { get; set; }
        public virtual ICollection<OrganizationEmployeeDocuments> OrganizationEmployeeDocuments { get; set; }
        public virtual ICollection<SysAdmin> SysAdmin { get; set; }
        public virtual ICollection<SysGatewayAccount> SysGatewayAccount { get; set; }
    }
}
