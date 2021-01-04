using FirmaAPP.Common;
using System;
using System.Collections.Generic;

namespace FirmaAPP.BusinessObject
{
    public class User
    {
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public Enums.UserRole UserRole { get; set; }
        public DateTime? LastLogin { get; set; }

        public AppSettings AppSettings { get; set; }
        public BusinessDetails BusinessDetails { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
