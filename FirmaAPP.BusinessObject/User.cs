using FirmaAPP.Common;
using System;
using System.Collections.Generic;

namespace FirmaAPP.BusinessObject
{
    public class User
    {
        public int UserID { get; set; }
        [LocalizedDisplayName("FirstName")]
        public string FirstName { get; set; }
        [LocalizedDisplayName("LastName")]
        public string LastName { get; set; }
        [LocalizedDisplayName("Password")]
        public string Password { get; set; }
        [LocalizedDisplayName("UserRole")]
        public Enums.UserRole UserRole { get; set; }
        [LocalizedDisplayName("LastLogin")]
        public DateTime? LastLogin { get; set; }

        public AppSettings AppSettings { get; set; }
        public BusinessDetails BusinessDetails { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
