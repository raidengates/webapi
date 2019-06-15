using System;
using System.Collections.Generic;

namespace Identity.Data.Entities
{
    public partial class Password
    {
        public int PasswordId { get; set; }
        public int UserId { get; set; }
        public string Password1 { get; set; }
        public string PasswordSalt { get; set; }
        public string PasswordAnswer { get; set; }
        public string PasswordQuestion { get; set; }
        public bool? Active { get; set; }
        public int CreatedByUserId { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual User User { get; set; }
    }
}
