using FirmaAPP.Common;
using System.Collections.Generic;
using System.ComponentModel;

namespace FirmaAPP.BusinessObject
{
    public class Customer
    {
        public int CustomerID { get; set; }

        [DisplayName("Nume")]
        public string FirstName { get; set; }
        [DisplayName("Prenume")]
        public string LastName { get; set; }
        [DisplayName("Oraș")]
        public string City { get; set; }
        [DisplayName("Județ")]
        public string County { get; set; }
        [DisplayName("Țară")]
        public string Country { get; set; }
        [DisplayName("Adresă")]
        public string Adress { get; set; }
        [DisplayName("Telefon")]
        public string Phone { get; set; }
        public string CUI { get; set; }
        public bool TVAPaying { get; set; }
        public string IBAN { get; set; }
        public Enums.Rating Rating { get; set; }
        public string Description { get; set; }

        public ICollection<Order> Orders { get; set; }

    }
}
