using System.Collections.Generic;
using FirmaAPP.Common;

namespace FirmaAPP.BusinessObject
{
    public class Provider
    {
        public int ProviderID { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string Adress { get; set; }
        public string Phone { get; set; }
        public string CUI { get; set; }
        public Enums.Rating Rating { get; set; }
        public string Description { get; set; }
        public string IBAN { get; set; }
        public bool TVAPaying { get; set; }

        public ICollection<Order> Orders { get; set; }
        public ICollection<Tshirt> Tshirts { get; set; }
        public ICollection<Filament> Filaments { get; set; }
        public ICollection<OtherPurchase> OtherPurchases { get; set; }
        public ICollection<Vinyl> Vinyls { get; set; }
    }
}
