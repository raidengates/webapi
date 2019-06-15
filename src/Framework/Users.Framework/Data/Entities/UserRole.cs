using System;
using System.Collections.Generic;

namespace Identity.Data.Entities
{
    public partial class UserRole
    {
        public int UserRoleId { get; set; }
        public string UserRoleName { get; set; }
        public string UserRoleNote { get; set; }
        public bool? Active { get; set; }
        public int CreatedByUserId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int ModifiedByUserId { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
