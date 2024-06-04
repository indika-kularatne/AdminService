using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminService.Models
{
    public class MenuGroupModel
    {
        public Guid id { get; set; }

        public string groupName { get; set; }

        public short sortNo { get; set; }

        public Guid createdBy { get; set; }

        public DateTime createdDate { get; set; }

        public Guid? modifiedBy { get; set; }

        public DateTime? modifiedDate { get; set; }        

        public List<MenuModel> sysMenu { get; set; }

        public string groupClaims { get; set; }
    }

    public class MenuModel
    {
        public Guid? menuGroupId { get; set; }

        public Guid id { get; set; }

        public string controllerName { get; set; }

        public string displayName { get; set; }

        public string controllerAction { get; set; }

        public short sortNo { get; set; }

        public Guid createdBy { get; set; }

        public DateTime createdDate { get; set; }

        public Guid? modifiedBy { get; set; }

        public DateTime? modifiedDate { get; set; }

        public Guid? parentId { get; set; }

        public List<MenuModel> inverseParent { get; set; }
    }
}
