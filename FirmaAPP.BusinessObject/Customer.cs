using FirmaAPP.Common;
using System.Collections.Generic;

namespace FirmaAPP.BusinessObject
{
    public class Customer
    {
        public int CustomerID { get; set; }

        [LocalizedDisplayName("FirstName")]
        public string FirstName { get; set; }
        [LocalizedDisplayName("LastName")]
        public string LastName { get; set; }
        [LocalizedDisplayName("City")]
        public string City { get; set; }
        [LocalizedDisplayName("County")]
        public string County { get; set; }
        [LocalizedDisplayName("Country")]
        public string Country { get; set; }
        [LocalizedDisplayName("Address")]
        public string Address { get; set; }
        [LocalizedDisplayName("Phone")]
        public string Phone { get; set; }
        [LocalizedDisplayName("CUI")]
        public string CUI { get; set; }
        [LocalizedDisplayName("TVAPaying")]
        public bool TVAPaying { get; set; }
        [LocalizedDisplayName("IBAN")]
        public string IBAN { get; set; }
        [LocalizedDisplayName("Rating")]
        public Enums.Rating Rating { get; set; }
        [LocalizedDisplayName("Description")]
        public string Description { get; set; }

        public ICollection<Order> Orders { get; set; }

    }
}
