using System;
using System.Collections.Generic;

namespace WebApp.Framework.Data.Entities
{
    public partial class MenuPermission
    {
        public int MenuPermissionID { get; set; }
        public int MenuID { get; set; }
        public int? RoleID { get; set; }
        public int? UserID { get; set; }

        public virtual MenuBar Menu { get; set; }
    }
}