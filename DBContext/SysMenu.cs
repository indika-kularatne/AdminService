using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class SysMenu
    {
        public SysMenu()
        {
            InverseParent = new HashSet<SysMenu>();
        }

        public Guid Id { get; set; }
        public Guid? MenuGroupId { get; set; }
        public string ControllerName { get; set; }
        public string DisplayName { get; set; }
        public string ControllerAction { get; set; }
        public Guid? ParentId { get; set; }
        public short SortNo { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public Guid? ModifiedBy { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual SysMenuGroup MenuGroup { get; set; }
        public virtual SysMenu Parent { get; set; }
        public virtual ICollection<SysMenu> InverseParent { get; set; }
    }
}
