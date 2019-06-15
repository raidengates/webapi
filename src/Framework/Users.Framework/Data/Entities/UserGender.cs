using System;
using System.Collections.Generic;

namespace Identity.Data.Entities
{
    public partial class UserGender
    {
        public UserGender()
        {
            User = new HashSet<User>();
        }

        public int UserGenderId { get; set; }
        public string GenderName { get; set; }
        public int CreatedByUserId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int ModifiedByUserId { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual ICollection<User> User { get; set; }
    }
}
