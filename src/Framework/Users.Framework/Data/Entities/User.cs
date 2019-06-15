using System;
using System.Collections.Generic;

namespace Identity.Data.Entities
{
    public partial class User
    {
        public User()
        {
            Password = new HashSet<Password>();
        }

        public int UserId { get; set; }
        public int SupervisorUserId { get; set; }
        public int? UserGenderId { get; set; }
        public string AccountName { get; set; }
        public string CommonName { get; set; }
        public string GivenName { get; set; }
        public string MiddleName { get; set; }
        public string FamilyName { get; set; }
        public string FullName { get; set; }
        public string UserNote { get; set; }
        public bool? ExternalUser { get; set; }
        public string Photo { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        public bool? Active { get; set; }
        public int CreatedByUserId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int ModifiedByUserId { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string UserInfo { get; set; }

        public virtual UserGender UserGender { get; set; }
        public virtual ICollection<Password> Password { get; set; }
    }
}
